using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystem
{
    public class Library
    {

        public static void Pause()
        {
            Print("Press enter to continue...");
            GetInput();
            Console.Clear();
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Print()
        {
            Print("");
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static int ConvertStringToInteger(string s)
        {
            if (int.TryParse(s, out int result))
            {
                return result;
            }

            return 0;
        }
        public static float ConvertStringToFloat(string s)
        {
            if (float.TryParse(s, out float result))
            {
                return result;
            }

            return 0;
        }
        public static double ConvertStringToDouble(string s)
        {
            if (double.TryParse(s, out double result))
            {
                return result;
            }

            return 0;
        }
    }
}

