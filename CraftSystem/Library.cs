using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystem
{
    public class Library
    {

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void print()
        {
            Console.WriteLine();
        }
        public static string GetInput()
        {
            return Console.ReadLine();
        }
        public static void SetApplicationTitle(string message)
        {
            Console.Title = message;
        }

        public static double ConvertStringToDouble(string input)
        {
  
            if(double.TryParse(input, out double number))
            {
                return number;
            }

            return 0; 
        }
    }
}
