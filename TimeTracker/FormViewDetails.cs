using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Command;

namespace TimeTracker
{
    public partial class FormViewDetails : Form
    {
        ICommand command = new SubmitCommand("ShowCommand", "FormDomain");
        RemoteControl rc = new RemoteControl();
        //160 hours is the starting vacation balance
        private const int startingVacationBalance = 160;
        private const int employmentHistory = 1;

        public FormViewDetails()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormDomain");
            form.ShowDialog();
        }

        private void FormViewDetails_Load(object sender, EventArgs e)
        {
            setInfoFromFiles();
        }

        private void setInfoFromFiles()
        {
            this.vacationBalanceTextBox.Text = startingVacationBalance.ToString();
            this.ptoHistTextBox.Text = employmentHistory.ToString();
            this.managerTextBox.Text = FormRegister.userFilelines[2].ToString().Trim() + " " + FormRegister.userFilelines[3].ToString().Trim();
            this.employmentHistTextBox.Text = FormRegister.userFilelines[5].ToString() + (" Months"); ;
        }
    }
}
