using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.FileUtils;
using TimeTracker.Command;

namespace TimeTracker
{
    public partial class FormRegister : Form
    {
        public String salary = "";
        RemoteControl rc = new RemoteControl();
        public static Boolean isRegistered = false;
        static UserFileSingleton userFile = UserFileSingleton.getUserFileInstance();
        public static String userFileLocation = userFile.getUserFileLocation();
        public static string[] userFilelines = System.IO.File.ReadAllLines(userFileLocation);
        public static Boolean alreadyRegistered = false;
        //public static string[] lines = System.IO.File.ReadAllLines(userFileLocation);
        public FormRegister()
        {
            InitializeComponent();

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            initializeFile();
            disAllowRegistration();
        }

        void initializeFile()
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (!File.Exists(userFileLocation))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(userFileLocation))
                    {

                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("File could not be instantiated. Please create new File: " + userFileLocation);
            }
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ensureAllInfo())
            {
                this.Hide();
                Form form = rc.onShowPressed("FormDomain");
                form.ShowDialog();
                alreadyRegistered = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormIndex");
            form.ShowDialog();
        }


        ArrayList textList = new ArrayList();
        private Boolean ensureAllInfo()
        {
            if (firstNameTextBox.Text.Length == 0 || LastNameTextBox.Text.Length == 0 || managerFirstNameTextBox.Text.Length == 0 || ManagerLastNameTextBox.Text.Length == 0 || SalaryTextBox.Text.Length == 0 || EmploymentHistTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter all information before submitting");
                return false;
            }
            else if (new FileInfo(userFileLocation).Length > 0)
            {
                MessageBox.Show("Register information already exists.");

                return false;
            }
            //Else, add data to an arrayList to store information.
            else
            {
                textList.Add(firstNameTextBox.Text);
                textList.Add(LastNameTextBox.Text);
                textList.Add(managerFirstNameTextBox.Text);
                textList.Add(ManagerLastNameTextBox.Text);
                textList.Add(SalaryTextBox.Text);
                textList.Add(EmploymentHistTextBox.Text);
                writeToUserTextFile();
            }
            return true;
        }

        private void disAllowRegistration()
        {
            if (new FileInfo(userFileLocation).Length == 0)
            {
                return;
            }
            if (userFilelines[0].ToString().Length >= 1 && userFilelines[1].ToString().Length >= 1 && userFilelines[2].ToString().Length >= 1 && userFilelines[3].ToString().Length >= 1 && userFilelines[4].ToString().Length >= 1 && userFilelines[5].ToString().Length >= 1)
            {
                displayAllInfoAfterRegister();
                disableAllFields();
                MessageBox.Show("You are already registered.");
            }
        }

        private void disableAllFields()
        {
            firstNameTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;
            managerFirstNameTextBox.Enabled = false;
            ManagerLastNameTextBox.Enabled = false;
            SalaryTextBox.Enabled = false;
            EmploymentHistTextBox.Enabled = false;
        }
        private void displayAllInfoAfterRegister()
        {
            this.firstNameTextBox.Text = userFilelines[0].ToString().Trim();
            this.LastNameTextBox.Text = userFilelines[1].ToString().Trim();
            this.managerFirstNameTextBox.Text = userFilelines[2].ToString().Trim();
            this.ManagerLastNameTextBox.Text = userFilelines[3].ToString().Trim();
            this.SalaryTextBox.Text = userFilelines[4].ToString().Trim();
            this.EmploymentHistTextBox.Text = userFilelines[5].ToString().Trim();
        }

        public void writeToUserTextFile()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(userFileLocation))
                    for (int i = 0; i < textList.Count; i++)
                    {
                        file.WriteLine(textList[i].ToString());
                    }
                MessageBox.Show("Data saved to: " + userFileLocation);

            }
            catch (IOException e)
            {
                MessageBox.Show("Could not enter data in file. Please try again");
            }
        }
    }
}
