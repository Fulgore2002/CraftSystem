using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftSystem
{
    public class Person
    {
        private string personName = "Anonymous Player";
        private double Currency = 10.50;

        public Person(string name) 
        {
            personName = name;
        }
        public Person()
        { 
        


        }

        public string Information()
        {
            return $"{personName} has {Currency.ToString("C")}";
        }

        public string SetName()
        {
            Print("what would you like your name to be?");
            Print();

            personName = GetInput();

            return $"Your name has been updated to {personName}";
        }

    }


}