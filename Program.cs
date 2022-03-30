﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage");
            const int isFullTime = 1;
            const int isPartTime = 2; 
            int isPresent = 1;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empInput = random.Next(0, 3);
            switch (empInput)
            {
                case isFulTme:
                    Console.WriteLine("employee is present");
                    empHrs = 8;
                    break;
                case isPartTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;

            
            }
            empWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily Wage:{0}",empWage);
            Console.ReadLine();
        }
    }
}
