
namespace DefineClasses
{
    using System;
    public class GSMTest
    {
        private int numberOfInstances;
        private GSM[] gsmArray;
        
        public GSMTest(int number, GSM[] gsmArray)
        {
            this.numberOfInstances = number;
            this.gsmArray = gsmArray;

            foreach (GSM gsm in gsmArray)
            {
                Console.WriteLine(gsm.ToString());

            }

            Console.WriteLine(GSM.iPhone4S);
        }

    }
}
