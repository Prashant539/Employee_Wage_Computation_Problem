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
        public void CheckEmployee()
        {
            int empHrs = 0;
            int empWages = 0;
            int totalempWage = 0;
            for (int day = 0; day < Num_Of_working_Days; day++)
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
                empWages = empHrs * EMP_RATE_PER_HOUR;
                totalempWage += empWages;
                Console.WriteLine("Emp Wage : " + empWages);
            }
            Console.WriteLine("Total EmpWage:" + totalempWage);
        }
    }
}

        

    










