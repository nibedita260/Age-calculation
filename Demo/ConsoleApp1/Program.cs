using System;

namespace ConsoleApp1
{
    class Program
    {
        //cltr + K+C
        //cltr + K+U
        public void example()
        {
            Console.WriteLine("Welcome to here");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            ////string ip = console.readline();
            ////int n = convert.toint32(console.readline());
            ////console.writeline("" + ip + "number is" + n);
            //Demo d = new Demo();
            //d.Attendance();
            //EMpWage eMpWage = new EMpWage();
            //eMpWage.CalEmpWage();
            //EMpWageMonth eMpWageMonth = new EMpWageMonth();
            //eMpWageMonth.CalempWageperMonth();
            //CalWages calWages = new CalWages();
            //calWages.CalWage();
            CalLengthOfLine calLengthOfLine = new CalLengthOfLine();
            Console.WriteLine("The length of line: "+ calLengthOfLine.LengthOfLine(30,20,50,40));


        }
    }
 
    
    
}
