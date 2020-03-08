using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Command;
using System.Windows.Forms;

namespace TimeTracker.Command
{
    class SubmitCommand : ICommand
    {
        RemoteControl rc = new RemoteControl();
        String typeOfCommand = null;
        String typeOfForm = null;
        public SubmitCommand(String typeOfCommand, String typeOfForm)
        {
            if (typeOfCommand == "ShowCommand")
            {
                this.typeOfForm = typeOfForm;
                this.typeOfCommand = typeOfCommand;
                execute();
            }
            else
            {
                rc.onHideButtonPressed(typeOfCommand);
            }
        } 

        public void execute()
        {
            rc.onShowPressed(typeOfForm);
        }
    }

}
