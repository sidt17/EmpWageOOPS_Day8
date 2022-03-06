using System;

namespace EmployeeWageProblem
{
    /// <summary>
    /// Contains the Main Method
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculated Part Time Employee & Wage.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PartTimeEmp Wage = new PartTimeEmp();
            Wage.Calculateparttimewage();

        }
    }
}
