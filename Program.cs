namespace EmployeeProgramswithOOPS
{
   public class Program
    {
         static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!"); //hello
            //EmployeeAttendance.Attendance();
            //EmployeeWAGE.WAGE()
            //ComputeWAGEusingClassMethod.computeEmpWage();
            //MultipleCompanyWages.computeEmpWage("More", 25, 2, 15);
            //MultipleCompanyWages.computeEmpWage("Big Bazar", 3, 25, 16);
            //FOR SAVE WAGE
            //SaveWageofEachCompany More = new SaveWageofEachCompany("More", 25, 2, 15);
            //SaveWageofEachCompany BigBazar = new SaveWageofEachCompany("Big Bazar", 25, 2, 15);
            //More.computeEmpWage();
            //Console.WriteLine(More.toString());
            //BigBazar.computeEmpWage();
            //Console.WriteLine(BigBazar.toString());

            // INTERFACE APPROACH//

            EmpWage empwage = new EmpWage();
            empwage.addcompanyEmpWage("More", 20, 2, 15);
            empwage.addcompanyEmpWage("Big Bazar", 25, 2, 15);
            empwage.computeEmpWage();

        }
    }
}