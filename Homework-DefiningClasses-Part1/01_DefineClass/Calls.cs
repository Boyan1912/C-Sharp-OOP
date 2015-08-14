using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    public class Calls
    {
        public DateTime timeAndDateOfCall;
        public double duration;
        public string dialledNumber;
        public Calls(DateTime startCall, DateTime endCall, string number)
        {
            this.timeAndDateOfCall = startCall;
            this.duration = (endCall - startCall).TotalSeconds;
            this.dialledNumber = number;
        }

    }
}
