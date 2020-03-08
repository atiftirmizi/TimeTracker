using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker.Command
{
    class RemoteControl
    {
        SubmitCommand submitCommand;
        public void setCommand(SubmitCommand submitCommand)
        {
            this.submitCommand = submitCommand;
        }

        public void onHideButtonPressed(String formType)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.Hide();
        }

        public Form onShowPressed(String formType)
        {
            if (formType.Equals("FormRegister"))
            {
                return new FormRegister();
            }
            else if (formType.Equals("FormDomain"))
            {
                return new FormDomain(null);
            }
            else if (formType.Equals("FormIndex"))
            {
                return new FormIndex();
            }
            else if (formType.Equals("FormViewDetails"))
            {
                return new FormViewDetails();
            }
            return null;
            
        }

    }
}
