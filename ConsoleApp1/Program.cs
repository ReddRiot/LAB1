using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Input("How many Fibonacci numbers do you wish to print?");
            Console.WriteLine("====================================");
            int c = 0;
            int a = 0;
            int b = 1;
            int counter = 0;
            while (counter != num)
            {
                Console.WriteLine(b);
                c = b;
                b = a + b;
                a = c;
                counter += 1;
            }
            Console.ReadKey();
        }

        static int Input(string mes)
        {
            Console.WriteLine(mes);
            return Int32.Parse(Console.ReadLine());
        }
    }
   
    
}
