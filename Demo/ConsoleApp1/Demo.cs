using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Demo
    {
        const int IS_PRESENT = 1;
        public void Attendance()
        {
            Random r = new Random();
            int empCheck = r.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Present");
            else
                Console.WriteLine("Absent");
        }
    }
}
//CLR CLI JIT
