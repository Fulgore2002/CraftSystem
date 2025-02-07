using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftSystem
{
    public class Recipe
    {
        public string Name;
        public double Amount;
        public string AmountType;
        public double Value;
        public List<Item> Ingredients;
  
        public string GetIngredientList()
        {
            string output = "";
            foreach (Item item in Ingredients)
            {
                output += item.ToString();
            }


            return output;

        }
    }
}
