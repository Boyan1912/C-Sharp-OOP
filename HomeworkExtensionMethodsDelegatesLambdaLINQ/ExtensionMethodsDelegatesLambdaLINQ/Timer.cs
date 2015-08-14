using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{/*
    Problem 7. Timer

    Using delegates write a class Timer that can execute certain method at each t seconds.
*/

    public class Timer
    {
        private DateTime start;
        private double interval;
        public Action voidMethod;

        public Timer (DateTime start, double interval, Action method)
        {
            this.start = start;
            this.interval = interval;
            this.voidMethod = method;

            if (this.start.Minute == DateTime.Now.Minute)
            {
                this.voidMethod();
                this.start = this.start.AddSeconds(interval);
            }

        }
   
        public DateTime Start 
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
        public double Interval 
        { 
            get
            {
                return this.interval;
            }    
            set
            {
                this.interval = value;
            }
        
        }

        public Action VoidMethod
        { 
            get
            {
                return this.voidMethod;
            }
          set
            {
                this.voidMethod = value;
            }
        
        }



        public static void PrintTime()
        {
            Console.WriteLine("Timer called to action! It is {0:F}", DateTime.Now);
        }
    }
}
