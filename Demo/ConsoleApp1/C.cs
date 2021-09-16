using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class C
    {
        public void Sub(int a,int b)//method overloading
        {
            int c = a - b;
            Console.WriteLine("" + c);
        }
        public void Sub(double a, double b)//method overridng
        {
            double c = a - b;
            Console.WriteLine("" + c);
        }
        
    }
}
