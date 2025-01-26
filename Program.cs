using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int principal = '0';
            double rate = '0';
            int time = '0';
            //input principal of the loan
            Console.WriteLine("What is principal amount of the loan in dollars?");
            //collect the user input for the principal of the loan
            principal = Convert.ToInt32(Console.ReadLine());

            //input the interest rate
            Console.WriteLine("What is the interest rate(input 0.05 for 5%)?");
            //collect the user input for the interest rate
            rate = Convert.ToDouble(Console.ReadLine());

            //input the time in years to pay of the loan
            Console.WriteLine("What is the period of loan in years?");
            //collect the user input for the time to pay of the loan
            time = Convert.ToInt32(Console.ReadLine());

            //calculate the interest of the loan
            int interest = (int)(principal * rate * time);
            //output the result
            Console.WriteLine($"Total interest of loan: {interest} dollars");
            
        }
    }
}
