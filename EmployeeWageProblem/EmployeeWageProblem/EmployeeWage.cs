﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public void CheckEmployee()
        {
            int Present = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Present)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }

        }

    }
}








