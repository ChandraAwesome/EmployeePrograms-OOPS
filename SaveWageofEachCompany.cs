using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgramswithOOPS
{
    public class SaveWageofEachCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //
        private string company;
        private int EMP_RATE_PER_HOUR;
        private int NUM_OF_WORKING_DAYS;
        private int MAX_HRS_IN_MONTH;
        private int totalEmpWage;

        public SaveWageofEachCompany(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4; break;
                    case IS_FULL_TIME:
                        empHrs = 8; break;
                    default:
                        empHrs = 0; break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + company + "is" + totalEmpWage);
        }

        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + "is :" + this.totalEmpWage;
        }

    }
}
