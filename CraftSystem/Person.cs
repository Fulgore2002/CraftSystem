using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CraftSystem
{

    public class Person
    {
        private string name = "Anonymous Player";
        public double Currency = 10.5089445;
        public List<Item> Inventory = new List<Item>();

        public string Name
        {
            get => name;
            set => name = value;

        }
        public Person()
        {

            Inventory.Add(new Item()
            {
                Name = "Water",
                Description = "Clean, lovely, water",
                Amount = 2,
                Value = .0015,
                AmountType = "cup(s)"
            }
            );
            Inventory.Add(new Item()
            {
                Name = "Chamomile",
                Description = "Matricaria recutita, dried",
                Amount = 1,
                Value = 0.0875,
                AmountType = "tsp(s)"
            }
            );
            Inventory.Add(new Item()
            {
                Name = "Ashwagandha",
                Description = "Withania somnifera, extract",
                Amount = 1,
                Value = 0.7475,
                AmountType = "tsp(s)"
            }
            );
            Inventory.Add(new Item()
            {
                Name = "Lavender",
                Description = "Lavandula angustifolia, dried",
                Amount = 1,
                Value = 032.5,
                AmountType = "tsp(s)"
            }
            );
            Inventory.Add(new Item()
            {
                Name = "Lemon Balm",
                Description = "Melissa officinalis, dried",
                Amount = 1,
                Value = 0.87375,
                AmountType = "tsp(s)"
            }
            );
        }

        public string ShowInventoryItems()
        {
            string output = "Inventory:\n";
            foreach (Item item in Inventory)
            {
                output += "    *" + item.Name + Environment.NewLine;
            }
            return output;
        }

        public void Craft()
        {

        }

        public string Information()
        {
            return $"{name} {Currency.ToString("c")}";
        }
    }
}


