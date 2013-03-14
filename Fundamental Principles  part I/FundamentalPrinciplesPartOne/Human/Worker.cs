using System;
using System.Collections.Generic;
using System.Linq;
namespace Humans
{
    class Worker : Human
    {
        /*Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
            * and method MoneyPerHour() that returns money earned by hour by the worker. */

        public const int DaysInWeek = 5;

        private decimal WeekSalary { get; set; }
        private uint WorkHoursPerDay { get; set; }

        //constructor
        public Worker(string fName, string lName, decimal weekSalary, uint workHoursPerDay)
            : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (decimal)(this.WeekSalary / (this.WorkHoursPerDay * DaysInWeek));
            return moneyPerHour;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}: salary {2:C2}, hours per day: {3} and money per hour {4:C2} ",
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }

        //sort them by money per hour in descending order.
        public static List<Worker> SortByMoneyPerHour(List<Worker> workers)
        {
            var sortedWorkers =
            from worker in workers
            orderby worker.MoneyPerHour() descending
            select worker;

            List<Worker> sortedWorkersList = new List<Worker>(workers.Capacity);
            foreach (var item in sortedWorkers)
            {
                sortedWorkersList.Add(item);
            }
            return sortedWorkersList;
        }
    }
}