using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgramswithOOPS
{
    public class EmployeeWAGE
    {
        public static void WAGE()
        {
            int ATTND = 1;
            int WRK_PER_HOUR = 20;
            // input
            int empHRs = 0;
            int empWage = 0;
            Random random = new Random();
            //logic
            int empCheck = random.Next(0, 2);
            if (empCheck == ATTND)
            {
                empHRs = 8;
            }
            else
            {
                empHRs = 0;
            }
            empWage = empHRs * WRK_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
