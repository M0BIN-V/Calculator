using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class main
    {
        public static void Exit()
        {
            Console.SetCursorPosition(2, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  Enter (m) to return to the menu or Press (e) to exit : ");
            string n1 = Console.ReadLine();
            n1=n1.ToLower();

            switch (n1)
            {
                case "e":
                    {
                        break;
                    }
                case "m":
                    {
                        main.menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        format.ui();
                        Console.SetCursorPosition(2, 18);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  Please enter just (m) or (e)...");
                        Console.ReadKey();
                        main.Exit();
                        break;
                    }
            }
        }
        public static void menu()
        {
            format.ui();
            Console.SetCursorPosition(2, 13);
            Console.WriteLine("Please enter one of the specified numbers to select the operation:");
            Console.SetCursorPosition(2, 14);
            Console.WriteLine("1-plus(+)");
            Console.SetCursorPosition(2, 15);
            Console.WriteLine("2-minus(-)");
            Console.SetCursorPosition(2, 16);
            Console.WriteLine("3-multiplied(*)");
            Console.SetCursorPosition(2, 17);
            Console.WriteLine("4-division(/)");
            Console.SetCursorPosition(2, 18);
            Console.WriteLine("5-exit");
            Console.SetCursorPosition(68, 13);
            try
            {
                int f = int.Parse(Console.ReadLine());
                if (f == 1)
                {

                    Calculator.plus();

                }
                else if (f == 2)
                {
                    Calculator.minus();
                }
                else if (f == 3)
                {
                    Calculator.multiplied();
                }
                else if (f == 4)
                {
                    Calculator.division();
                }
                else if (f == 5)
                {
                    format.exit();
                }
                else if (f > 6 || f < 1)
                {
                    Console.Clear();
                    format.ui();
                    Console.SetCursorPosition(2, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select only one of the specified numbers.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    main.menu();
                }
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
                main.menu();
            }
            main.Exit();
        }
    }
}
