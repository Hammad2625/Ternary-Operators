using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String1 :");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter String2 :");
            string string2 = Console.ReadLine();

           string message= string1.Length > string2.Length ? "string1 is greater than string2" :
                "string1 is less than string2";
            Console.WriteLine(message);
        }
    }
}
