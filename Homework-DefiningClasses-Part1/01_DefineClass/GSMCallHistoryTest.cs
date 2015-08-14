using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    class GSMCallHistoryTest
    {
        /*Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

    Create an instance of the GSM class.
    Add few calls.
    Display the information about the calls.
    Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    Remove the longest call from the history and calculate the total price again.
    Finally clear the call history and print it.
*/


        static void Main(string[] args)
        {
            GSM gsm = new GSM("someModel", "Nokia");

            Console.WriteLine("Enter number of calls: ");
            int numberOfCalls = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string dialledNumber = "088";

            for (int i = 0; i < numberOfCalls; i++)
            {
                DateTime startCall = DateTime.Now.AddMinutes(rnd.Next(40000));
                Calls newCall = new Calls(startCall, startCall.AddSeconds(rnd.Next(0, 360)), dialledNumber + rnd.Next(9999999).ToString());
                gsm.AddCalls(newCall);

            }


            foreach (Calls call in gsm.CallHistory)
            {
                Console.WriteLine("Call info: \n Date of call: {0:MM/dd/yyyy} \n Time of call: {1:hh:mm:ss} \n Duration: {2} seconds \n Dialled Number: {3}", call.timeAndDateOfCall, call.timeAndDateOfCall, 
                    call.duration, call.dialledNumber);

            }

            Console.WriteLine();
            Console.WriteLine("Total costs: {0:C}", gsm.CalculatePrice());

            double bestDuration = 0;
            int bestIndex = 0;
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].duration > bestDuration)
                {
                    bestIndex = i;
                }
            }

            gsm.DeleteCalls(bestIndex);
            Console.WriteLine();
            Console.WriteLine("Total costs after removing longest duration call: {0:C}", gsm.CalculatePrice());

            gsm.ClearCallHistory();
            if (gsm.CallHistory.Count < 1)
            {
                Console.WriteLine();
                Console.WriteLine("Call history successfully deleted.");
            }

        }


    }
}
