using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FUlL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Num_Of_working_Days = 3;
        public const int Max_Hrs_In_Month = 10;
        public void CheckEmployee()
        {
            int empHrs = 0;
            int empWages = 0;
            int totalempWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_working_Days)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FUlL_TIME:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is part time ");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            totalempWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage for a Month: " + totalempWage);
        }
    }
}

        

    










