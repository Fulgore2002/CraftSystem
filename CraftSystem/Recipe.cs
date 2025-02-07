using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CraftingSystemMonday
    {
        public class Recipe
        {
            public string Name;
            public string Description;
            public List<Item> Ingredients = new List<Item>();

            public Recipe()
            {

            }
            public Recipe(string name, string description, List<Item> items)
            {
                Name = name;
                Description = description;
                Ingredients = items;
            }

            public string Information()
            {
                return $"    *{Name} ({Description})";
            }
        }
    }
}
