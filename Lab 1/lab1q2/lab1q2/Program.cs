using System;
using Arithematics;

public class Program
{
    static void Main()
    {
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulo");
        Console.WriteLine("Select an operation");
        ArithmeticOperations d = new ArithmeticOperations();
        int option = int.Parse(Console.ReadLine());
        if (option >= 1 && option <= 5)
        {
            Console.WriteLine("Enter Two Numbers");
            double a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        //if (a.Contains(".") && b.Contains("."))
                            Console.WriteLine(d.Add((a), (b)));
                        //else
                        //    Console.WriteLine(d.Add(int.Parse(a), int.Parse(b)));
                        break;
                    }

                case 2:
                    {
                    //if (a.Contains(".") && b.Contains("."))
                        Console.WriteLine(d.Subtract((a), (b)));
                    //else
                    //    Console.WriteLine(d.Subtract(int.Parse(a), int.Parse(b)));
                    break;
                    }

                case 3:
                    {
                        //if (a.Contains(".") && b.Contains("."))
                            Console.WriteLine(d.Multiply((a), (b)));
                        //else
                        //    Console.WriteLine(d.Multiply(int.Parse(a), int.Parse(b)));
                        break;
                    }

                case 4:
                    {
                       // if (a.Contains(".") && b.Contains("."))
                            Console.WriteLine(d.Division((a), (b)));
                        //else
                        //    Console.WriteLine(d.Division(int.Parse(a), int.Parse(b)));
                        break;
                    }

                case 5:
                    {
                       // if (a.Contains(".") && b.Contains("."))
                            Console.WriteLine(d.Modulo((a),(b)));
                        //else
                        //    Console.WriteLine(d.Modulo(int.Parse(a), int.Parse(b)));
                        break;
                    }

            }
        }
        else
            Console.WriteLine("Wrong Input");
    }
}