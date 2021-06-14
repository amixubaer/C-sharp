using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Name
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + (name));
            Console.ReadLine();
        }
    }
}
