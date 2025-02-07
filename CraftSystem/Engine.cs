using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CraftSystem.Library;

namespace CraftSystem
{
    internal class Engine
    {

        Person Player = new Person();
        string applicationTitile = "Awesome Crafting System";

        public void Start()
        {
            SetApplicationTitle(applicationTitile);


            WriteLine(Player.Information());
            ReadKey();
        }


        
    }
}
