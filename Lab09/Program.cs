using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        public static int numOfCircles = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle area & circumference calculator. ");
            GetUserInput();
        }

        private static void GetUserInput()
        {
            Console.Write("Enter a radius: ");
            bool bit = double.TryParse(Console.ReadLine(), out double userInput);

            if (bit)
            {
                numOfCircles++;
                Circle circle = new Circle(userInput);
                WriteResponse(circle.CalculateCircumference(userInput), circle.CalculateArea(userInput), numOfCircles);
            }
            else
            {
                Console.WriteLine("Your input was invalid.\n");
                GetUserInput();
            }
        }

        private static void WriteResponse(double circumference, double area, int numOfCircles)
        {
            Console.WriteLine("Circumference: \t{0} \nArea: \t{1} \nNumber of Circles: \t{2}", circumference, area, numOfCircles);
            QuitConsoleApp();
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
