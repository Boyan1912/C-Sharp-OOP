
namespace DefineClasses
{
    using System;
using System.Collections.Generic;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery phoneBattery;
        private Display phoneDisplay;
        public static string iPhone4S = "The iPhone 4S is a touchscreen-based smartphone developed, manufactured, and released by Apple Inc. It is the fifth generation of the iPhone,[8] succeeding the iPhone 4 and preceding the iPhone 5.";
        private List<Calls> callsHistory = new List<Calls>();
        private const double pricePerMinute = 0.37;

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.phoneBattery = battery;
            this.phoneDisplay = display;
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            
        }
        public string Model
        {
            get { return this.model; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The GSM Model's field cannot be empty!");

                }
                this.model = value;

            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The GSM Manufacturer's field cannot be empty!");

                }
                this.manufacturer = value;

            }

        }

        public string Owner 
        {
            
            get
            {
                return this.owner;
            }
               set
            {
                this.owner = value;
            }
               
        }

        public double Price 
        {
            get { return this.price; }
        
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be of negative value!");
                }

                this.price = value;

            }
                
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callsHistory;
            }

            set 
            {
                this.callsHistory = CallHistory;
            }
        }
        public override string ToString()
        {
            string info = "";
            try
            {
                    info = string.Format("The mobile phone device's model is {0}. It is manufactered by {1}. Battery model is {2}. The phone's display is {3} inches in diagonal and can produce {4} colours. The phone costs {5:c} and is owned by {6}",
                    model, manufacturer, phoneBattery.Model, phoneDisplay.Size, phoneDisplay.NumberOfColours, price, owner);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Not enough data to display full phone information!");
            }

            return info;
        }
        
        
        public void AddCalls(Calls newCall)
        {

            this.callsHistory.Add(newCall);
        }

       public void DeleteCalls(int index)
        {
            this.callsHistory.RemoveAt(index);

        }
        public void ClearCallHistory()
       {
           this.callsHistory.Clear();
       }

        public double CalculatePrice()
        {
            double totalDurations = 0;
            

            foreach (Calls calls in this.callsHistory)
            {
                totalDurations += calls.duration;

            }

            return totalDurations * pricePerMinute * 1 / 60;

        }

      
    }
}
