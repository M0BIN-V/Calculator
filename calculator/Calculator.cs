using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
        public static void plus()
        {
            Console.Clear();
            Double Num1, Num2;
            format.plus();
            format.numberbox();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(31, 14);
            Console.WriteLine("+");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 14);
            Console.Write("enter number 1:");
            try
            {
                Num1 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(35, 14);
                Console.Write("enter number 2:");
                Num2 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(64, 14);
                Console.WriteLine(Num1 + Num2);
            }
            catch
            {
                Console.Clear();
                format.plus();
                Console.SetCursorPosition(2, 15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter just number...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Calculator.plus();
            }
        }
        public static void minus()
        {
            Double Num1, Num2;
            format.minus();
            format.numberbox();
            Console.SetCursorPosition(31,14);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 14);
            Console.Write("enter number 1:");
            try
            {
                Num1 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(35, 14);
                Console.Write("enter number 2:");
                Num2 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(64, 14);
                Console.WriteLine(Num1 - Num2);
            }
            catch
            {
                Console.Clear();
                format.multiplied();
                Console.SetCursorPosition(2, 15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter just number...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Calculator.minus();
            }
        }
        public static void multiplied()
        {
            Console.Clear();
            format.division();
            format.numberbox();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(31, 14);
            Console.WriteLine("*");
            Console.ResetColor();
            Double Num1, Num2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 14);
            Console.Write("enter number 1:");
            try
            {
                Num1 = Double.Parse(Console.ReadLine());

                Console.SetCursorPosition(35, 14);
                Console.Write("enter number 2:");
                Num2 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(64, 14);
                Console.WriteLine(Num1 * Num2);
            }
            catch
            {
                Console.Clear();
                format.ui();
                Console.SetCursorPosition(2, 15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter just number...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Calculator.multiplied();
            }
        }
        public static void division()
        {
            Double Num1, Num2;
            format.division();
            format.numberbox();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(31, 14);
            Console.Write("/");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(6, 14);
            Console.Write("enter number 1:");
            try
            {
                Num1 = Double.Parse(Console.ReadLine());

                Console.SetCursorPosition(35, 14);
                Console.Write("enter number 2:");
                Num2 = Double.Parse(Console.ReadLine());
                Console.SetCursorPosition(64, 14);
                Console.WriteLine(Num1 / Num2);
            }
            catch
            {
                Console.Clear();
                format.ui();
                Console.SetCursorPosition(2, 15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter just number...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                Calculator.division();
            }
        }
    }
}

