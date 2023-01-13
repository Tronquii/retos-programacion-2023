using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int x=0; x<=100;x++) 
            {

                if (x % 3 == 0 && x % 5 == 0 && x !=0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 3 == 0 && x != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0 && x != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(x);
                }
                          
                
            }
            Console.WriteLine();
        }
    }
}
