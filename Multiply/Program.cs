using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[2];
            int[] num2 = new int[2];
            int i;
            int j;

            Console.WriteLine("Number Size is max 2");

            Console.WriteLine("Input First Input :");
            for (i = 0; i < 2; i++)
            {
                Console.Write("element - {0} of first input : ", i);
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Input Second Input :");
            for (j = 0; j < 2; j++)
            {
                Console.Write("element - {0} of second input: ", j);
                num2[j] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Output:"+(num1[0]*num2[0])+ (num1[0]+num2[0]) + (num1[1] * num2[1]));
            Console.ReadLine();

        }
    }
}
