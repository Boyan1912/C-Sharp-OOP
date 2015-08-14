
namespace DefineClasses
{
    using System;
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        public Battery(string model, int hoursIdle, int talk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = talk;
            this.type = type;
        }

        public Battery(string model)
        {
            this.Model = model;

        }

        public string Model
        {
            get { return this.model; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Battery's model field cannot be empty!");

                }
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The time the phone wasn't used cannot be negative!");
                }

                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The time the phone was in use cannot be negative!");
                }

                this.hoursTalk = value;
            }
        }

        public enum BatteryType
        {
            LiIon, NiMH, NiCd, LeadAcid, LiIonPolymer, ReusableAlkaline
        }



    }
}