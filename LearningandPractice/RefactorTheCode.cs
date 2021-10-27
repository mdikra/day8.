﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class RefactorTheCode
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        public static int ComputeEmpWage()
        {

        }
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            //computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
    }
}
