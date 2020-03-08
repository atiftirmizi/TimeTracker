using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.State
{
    class ClockInState
    {
        Boolean clockedIn;
        public void isClockedIn(Boolean output)
        {
            this.clockedIn = output;
            
        }

        public Boolean clockedInState()
        {
            return clockedIn;
        }
    }
}
