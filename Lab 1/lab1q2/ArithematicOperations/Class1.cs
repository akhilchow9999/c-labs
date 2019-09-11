using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arithematics
{
    public class ArithmeticOperations
    {
        //public int Add(int a, int b)
        //{ return (a + b); }
        //public int Subtract(int a, int b)
        //{ return (a - b); }
        //public int Multiply(int a, int b)
        //{ return (a * b); }
        //public double Division(int a, int b)
        //{
        //    if (b != 0)
        //        return (a / b);
        //    else
        //        Console.WriteLine("Invalid Operation");
        //    return 0;
        //}
        //public int Modulo(int a, int b)
        //{ return (a % b); }
        public double Add(double a, double b)
        { return (a + b); }
        public double Subtract(double a, double b)
        { return (a - b); }
        public double Multiply(double a, double b)
        { return (a * b); }
        public double Division(double a, double b)
        {
            if (b != 0)
                return (a / b);
            else
                Console.WriteLine("Invalid Operation");
            return 0;
        }
        public double Modulo(double a, double b)
        {
            return (a % b);
        }
    }
}

