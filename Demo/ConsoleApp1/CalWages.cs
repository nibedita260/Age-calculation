using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CalWages
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2, TOTAL_WORKING_DAYS = 20, TOTAL_WORKING_HRS = 100;
        int working_days=0,working_hrs=0,empHrs=0,totalWages=0, empDailyWages;
        public void CalWage()
        {
            Random r = new Random();
            int empCheck = r.Next(0, 3);
            while(working_days<=TOTAL_WORKING_DAYS && working_hrs <= TOTAL_WORKING_HRS)
            {
                //if(empCheck==IS_PRESENT)
                //{
                //    Console.WriteLine("employee is Present");
                //}
                //else
                //{
                //    Console.WriteLine("employee is Absent");
                //}
                switch (empCheck)
                {
                    case IS_FULLTIME: empHrs = FULL_DAY_HR;
                        break;
                    case IS_PARTTIME: empHrs = PART_TIME_HR;
                        break;
                    default: empHrs = 0;
                        break;
                }
                Console.WriteLine("emphours: " + empHrs);
                working_days=working_days+1;
                working_hrs =working_hrs+ empHrs;
                Console.WriteLine("emp working hours: " + working_hrs);
                empDailyWages = WAGE_PER_HOUR * empHrs;
                Console.WriteLine("emp daily wage: " + empDailyWages);
                totalWages += empDailyWages;
                
            }
            Console.WriteLine("emp work hour: "+working_hrs +"emp daily wages" +empDailyWages +" and total wages: "+totalWages);
        }
        
    }
}
