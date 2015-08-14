using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RangeExceptions
{
    public class InvalidRangeException<T> : Exception
    {

        private T start;
        private T end;
        private string message;

        public InvalidRangeException(T start, T end)
            : base()
        {
            this.Start = start;
            this.End = end;
            this.CustomMessage = string.Format("Value must be between {0} and {1}", this.Start, this.End);
        }

        public InvalidRangeException(string message) : base(message, null)
        {
        }

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }

        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }

        }

        public string CustomMessage
        
        { 
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        
        }



    }
}
