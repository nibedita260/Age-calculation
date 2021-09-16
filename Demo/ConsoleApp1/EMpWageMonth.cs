using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EMpWageMonth
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, TOTAL_WORKING_DAYS=20,FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2;
        int totalWage = 0, empHrs = 0;
        public void CalempWageperMonth()
        {
            for(int i = 1; i < TOTAL_WORKING_DAYS; i++)
            {
                totalWage = WAGE_PER_HOUR* FULL_DAY_HR;
            }
            Console.WriteLine("wages per month: " + totalWage);
        }
    }
}
