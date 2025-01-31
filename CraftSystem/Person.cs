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
    }

    public string Information()
    {
        return $"{personName} has {Currency.ToString("C")}";
    }
}