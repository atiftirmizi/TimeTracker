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
    public partial class FormIndex : Form
    {
        RemoteControl rc = new RemoteControl();
        public FormIndex()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormRegister");
            form.ShowDialog();
        }

        private void ClockInOrOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = rc.onShowPressed("FormDomain");
            form.ShowDialog();
        }
    }
}
