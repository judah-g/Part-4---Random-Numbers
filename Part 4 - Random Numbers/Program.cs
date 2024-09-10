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
            int num1, num2, die1, die2;

            Console.WriteLine("give me a range for some numbers");
            Console.Write("give me a minimum\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            num1++;

            Console.Write("now i want a maximum\t");
            num2 = num1 - 1;
            while (num2 < num1)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < num1) { Console.WriteLine("nope"); }
            }

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
            System.Threading.Thread.Sleep(4000);
            Console.Clear();

            //random decimal


        }
    }
}
