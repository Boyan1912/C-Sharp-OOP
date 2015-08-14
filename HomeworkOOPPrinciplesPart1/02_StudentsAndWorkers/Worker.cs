using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers
{
    public class Worker : Human
    {

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay, double wage) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.Wage = wage;
        }

        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double Wage { get; set; }

        public double MoneyPerHour()
        {
            return this.Wage;

        }




    }
}
