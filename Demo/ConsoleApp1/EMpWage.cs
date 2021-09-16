using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EMpWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2;
        int totalWage = 0, empHrs = 0;
        public void CalEmpWage()
        {

            Random r = new Random();
            int empCheck = r.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULLTIME: empHrs += FULL_DAY_HR;
                    break;
                case IS_PARTTIME: empHrs += PART_TIME_HR;
                    break;
                default:
                    empHrs += 0;
                    break;
            }
            if (empCheck == IS_PRESENT)
            {
                totalWage = WAGE_PER_HOUR * FULL_DAY_HR;
            }
            else
            {
                totalWage = WAGE_PER_HOUR * PART_TIME_HR;

            }
            Console.WriteLine(totalWage);
        }
    }
}