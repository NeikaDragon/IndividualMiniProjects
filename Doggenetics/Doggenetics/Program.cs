using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            int sum = 100;
            

            Console.WriteLine("What is your dogs name?");
            string input = Console.ReadLine();
            Console.WriteLine($"Great! I have a pretty reliable report that {input} is");

            while (a+b+c+d+e < sum)
            {
                Random r = new Random();
                a = r.Next(0, sum);
                b = r.Next(0, sum - a);
                c = r.Next(0, sum - a - b);
                d = r.Next(0, sum - a - b - c );
                e = ( sum - a - b - c - d);


                Console.WriteLine($"{a} % Labrador");
                Console.WriteLine($"{b} % German Shepard");
                Console.WriteLine($"{c} % Husky");
                Console.WriteLine($"{d} % Shiba Inu");
                Console.WriteLine($"{e} % Corgi");
                Console.WriteLine($"{a + b + c + d + e} is the sum of your dog");
                Console.ReadLine();
                
                
            }
        }
    }
}
