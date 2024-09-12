using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // judah
            //random numbers

            Random generator = new Random();
            int num1, num2, die1, die2, decimalCounter = 0;
            decimal double1, double2, decimalTester, answer;
            
            Console.WriteLine("give me a range for some numbers");
            Console.Write("give me a minimum\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("now i want a maximum\t");
            num2 = num1 - 1;
            while (num2 < num1)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < num1) { Console.WriteLine("nope"); }
            }
            num2++;

            Console.WriteLine("here are your numbers");
            for (int i = 0; i <=4;  i++)
            {
                Console.WriteLine(generator.Next(num1, num2));
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //dice roller

            Console.WriteLine("i'm rolling two dice");
            die1 = generator.Next(1, 7); die2 = generator.Next(1, 7);
            Console.WriteLine($"i got {die1} and {die2}");
            Console.WriteLine($"they add up to {die1 + die2}");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //random decimal

            Console.WriteLine("i need some more precise numbers this time");
            Console.Write("give me a minimum\t");
            double1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("now i want a maximum\t");
            double2 = double1 - 1;
            while (double2 < double1)
            {
                double2 = Convert.ToDecimal(Console.ReadLine());
                if (double2 < double1) { Console.WriteLine("another"); }
            }

            decimalTester = double1 - (int)double1;
            decimalTester = Math.Round(decimalTester, 5);
            while (decimalTester > 0)
            {
                decimalCounter++;
                decimalTester *= 10;
                decimalTester -= (int)decimalTester;
                double1 *= 10;
                double2 *= 10;
            }

            Console.WriteLine("here are your numbers");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(generator.Next(Convert.ToInt32(double1), Convert.ToInt32(double2 + 1)) / Math.Pow(10, decimalCounter));
                System.Threading.Thread.Sleep(1000);
            }
            System.Threading.Thread.Sleep(1000);

            //had some issues with decimal innaccuracy resulting in numbers too big for ints
        }
    }
}
