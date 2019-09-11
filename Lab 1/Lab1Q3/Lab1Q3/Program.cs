using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("Entered Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Entered Value is 2");
                    break;
                case 3:
                    Console.WriteLine("Entered Value is 3");
                    break;
                case 4:
                    Console.WriteLine("Entered Value is 4");
                    break;
                case 5:
                    Console.WriteLine("Entered Value is 5");
                    break;
                default:
                    Console.WriteLine("Wrong Value");
                    break;
            }
        }
    }
}
