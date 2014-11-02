using System;

namespace _02.Human
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double result = 0.0;

            result = this.WeekSalary / (5 * this.WorkHoursPerDay);

            return result;
        }

        public override string ToString()
        {
            string result = null;

            result = string.Format("{0} {1} earns {2} per hour", this.FirstName, this.LastName, this.MoneyPerHour());

            return result;
        } 

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
    }
}
