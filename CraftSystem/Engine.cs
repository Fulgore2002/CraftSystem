using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CraftSystem
{
    public class Engine
    {

        Person Player = new Person();

        static void Start()
        {
            Title = "Awesome Crafting System";
            WriteLine("Hello, World!");
            ReadKey();
        }
    }
}
