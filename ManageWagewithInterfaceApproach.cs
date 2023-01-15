using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgramswithOOPS
{
    public class ManageWagewithInterfaceApproach
    {
        //public const int IS_PART_TIME = 1;
        //public const int IS_FULL_TIME = 2;
        //
        public string company;
        public int EMP_RATE_PER_HOUR;
        public int NUM_OF_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int totalEmpWage;

        public ManageWagewithInterfaceApproach(string company, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company :" + this.company + "is :" + this.totalEmpWage;
        }
    }

    public class EmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numofcompany = 0;                                                                   // NEED TO UNDERSTAND A LOT WITH THIS PROGRAM AND LOGIC...UNKNOWN TO ME//
        private ManageWagewithInterfaceApproach[] companyEmpWageArray;

        public EmpWage()
        {
            this.companyEmpWageArray = new ManageWagewithInterfaceApproach[5];
        }

        public void addcompanyEmpWage(string company,int EMP_RATE_PER_HOUR,int NUM_OF_WORKING_DAYS,int MAX_HRS_IN_MONTH) 
        {
            companyEmpWageArray[this.numofcompany] = new ManageWagewithInterfaceApproach(company, EMP_RATE_PER_HOUR, NUM_OF_WORKING_DAYS, MAX_HRS_IN_MONTH);
            numofcompany++;
        }

        public void computeEmpWage()
        {
            for (int i=0; i<numofcompany; i++) 
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int  computeEmpWage(ManageWagewithInterfaceApproach compamyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //
            while (totalEmpHrs <= compamyEmpWage. MAX_HRS_IN_MONTH && totalWorkingDays <compamyEmpWage. NUM_OF_WORKING_DAYS)
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
            return totalEmpHrs * compamyEmpWage.EMP_RATE_PER_HOUR;
            //totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            //Console.WriteLine("Total Emp Wage :" + company + "is" + totalEmpWage);
        }
        
        
    }
}