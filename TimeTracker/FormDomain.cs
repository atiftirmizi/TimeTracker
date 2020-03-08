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
using TimeTracker.State;

namespace TimeTracker
{
    
    public partial class FormDomain : Form
    {
        RemoteControl rc = new RemoteControl();
        static TimeFileSingleton timeFile = TimeFileSingleton.getInstance();
        static String timeFileLocation = timeFile.getTimeFileLocation();

        static CommentsFileSingleton commentsFile = CommentsFileSingleton.getCommentsInstance();
        static String commentsFileLocation = commentsFile.getTimeFileLocation();
        public string[] commentsFilelines = System.IO.File.ReadAllLines(commentsFileLocation);

        public FormDomain(String salaryTextBoxValue)
        {
            InitializeComponent();
            this.payTextBox.Text = salaryTextBoxValue;
        }

        private void FormDomain_Load(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToLongTimeString();
            currentDateLabel.Text = DateTime.Now.ToLongDateString();
            if (FormRegister.alreadyRegistered)
            {
                setPayFromTextFile();
            }
           
        }

        private void payTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void concernsButton_Click(object sender, EventArgs e)
        {
            submitCommentsOrConcerns();            
        }
        String comments; 
        public void submitCommentsOrConcerns()
        {
            comments = commentsTextBox.Text;
            if(!String.IsNullOrEmpty(comments)|| comments.Length > 0)
            {
                System.IO.File.WriteAllText(commentsFileLocation, comments);
                MessageBox.Show("Comments saved in " + commentsFileLocation);
            }
            else
            {
                MessageBox.Show("Please enter a comment before submitting");
            }          

        }
        String timeInStamp;
        String timeOutStamp;
        ClockInState clockIn = new ClockInState();
        ArrayList timeInList = new ArrayList();
        private void clockInButton_Click(object sender, EventArgs e)
        {
            
            clockIn.isClockedIn(true);
            if (clockIn.clockedInState())
            {
                timeInStamp = DateTime.Now.ToString("h:mm:ss tt");
                this.clockInButton.Enabled = false;
                this.clockOutButton.Enabled = true;
                MessageBox.Show("You clocked in at " + timeInStamp);
                writeToTimeFile();
            }
            else
            {
                this.clockInButton.Enabled = true;
                this.clockOutButton.Enabled = false;
            }
            

        }
        private void clockOutButton_Click(object sender, EventArgs e)
        {
            clockIn.isClockedIn(false);
            if (!clockIn.clockedInState())
            {
                timeOutStamp = DateTime.Now.ToString("h:mm:ss tt");
                this.clockOutButton.Enabled = false;
                this.clockInButton.Enabled = true;
                MessageBox.Show("You clocked out at " + timeOutStamp);
            }
            else
            {
                this.clockOutButton.Enabled = true;
                this.clockInButton.Enabled = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            commentsTextBox.Text = null;
        }

        private void ptoDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormViewDetails");
            form.ShowDialog();
        }

        private void calculateVacationInfo()
        {            
            if(this.dateTimePicker1.Value < this.dateTimePicker2.Value)
            {
                this.dateTimePicker1.Value.ToShortDateString();

                DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

                MessageBox.Show("Total Days of vacation are: " +outTime.Subtract(inTime).Days.ToString());
        
            }
            else
            {
                MessageBox.Show("The First Date must be lesser than the 'To' Date.");
            }

            //MessageBox.Show(this.dateTimePicker1.Value.ToShortDateString());
        }

        private void ptoButton_Click(object sender, EventArgs e)
        {
            calculateVacationInfo();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormIndex");
            form.ShowDialog();
        }

        public void readTextFiles()
        {
            
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in FormRegister.userFilelines)
            {                
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            //Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        private void setPayFromTextFile()
        {
           
                if (FormRegister.userFilelines[0].ToString().Length == 0)
                {
                    MessageBox.Show("Please enter register information");
                    FormDomain formDomain = new FormDomain(null);
                    formDomain.Hide();
                    new FormRegister().ShowDialog();
                }
                else
                {
                    this.payTextBox.Text = FormRegister.userFilelines[4];
                }
                       
            
        }
                

        public void writeToTimeFile()
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(timeFileLocation))
                    if (new FileInfo(timeFileLocation).Length < 1)
                    {
                        timeInList.Add(timeInStamp);
                        for (int i = 0; i < timeInList.Count; i++)
                        {
                            file.WriteLine(timeInList[i].ToString() + "|");
                        }
                    }                    
                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = File.AppendText(timeFileLocation))
                    {
                        for (int i = 0; i < timeInList.Count; i++)
                        {
                        sw.WriteLine(timeInList[i].ToString() + "|");
                        }

                }
                //MessageBox.Show("Data saved to: " + timeFileLocation);

            }
            catch (IOException e)
            {
                MessageBox.Show("Could not enter data in file. Please try again");
            }
        }

        
    }
}
