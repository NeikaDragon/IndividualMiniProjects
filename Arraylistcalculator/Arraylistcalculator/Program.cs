using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylistcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] arr2 = { 999, -60, -77, 14, 160, 301 };
            int[] arr3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
        140, 150, 160, 170, 180, 190, 200, -99 };

            int num = arr1.Sum();
            int total = arr2.Sum();
            int sum = arr3.Sum();



            Console.WriteLine($"The sum of the first array is {num}");
            Console.WriteLine($"The sum of the second array is {total}");
            Console.WriteLine($"The sum of the third array is {sum}");
            Console.ReadLine();

        }
    }
}

    

