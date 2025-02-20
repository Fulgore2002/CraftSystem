using System;
using System.Collections.Generic;
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
            Inventory.Add(new Item
            {
                Name = "Water",
                Description = "Clean, lovely, water",
                Amount = 2,
                Value = 0.0015,
                AmountType = "cup(s)"
            });

            Inventory.Add(new Item
            {
                Name = "Chamomile",
                Description = "Matricaria recutita, dried",
                Amount = 1,
                Value = 0.0875,
                AmountType = "tsp(s)"
            });

            Inventory.Add(new Item
            {
                Name = "Ashwagandha",
                Description = "Withania somnifera, extract",
                Amount = 1,
                Value = 0.7475,
                AmountType = "tsp(s)"
            });

            Inventory.Add(new Item
            {
                Name = "Lavender",
                Description = "Lavandula angustifolia, dried",
                Amount = 1,
                Value = 0.0325,
                AmountType = "tsp(s)"
            });

            Inventory.Add(new Item
            {
                Name = "Lemon Balm",
                Description = "Melissa officinalis, dried",
                Amount = 1,
                Value = 0.87375,
                AmountType = "tsp(s)"
            });
        }

        public string ShowInventoryItems()
        {
            StringBuilder output = new StringBuilder("Inventory:\n");
            foreach (Item item in Inventory)
            {
                output.AppendLine("    * " + item.Name);
            }
            return output.ToString();
        }

        public Item CraftItem(Recipe recipe)
        {
            foreach (Item ingredient in recipe.Ingredients)
            {
                Item playerItem = Inventory.FirstOrDefault(i => i.Name == ingredient.Name);
                if (playerItem == null || playerItem.Amount < Library.ConvertToTeaspoons(ingredient.Amount, ingredient.AmountType))
                {
                    Console.WriteLine($"You don't have enough {ingredient.Name}.");
                    return null;
                }
            }

            foreach (Item ingredient in recipe.Ingredients)
            {
                Item playerItem = Inventory.First(i => i.Name == ingredient.Name);
                playerItem.Amount -= Library.ConvertToTeaspoons(ingredient.Amount, ingredient.AmountType);
            }

            Item craftedItem = new Item
            {
                Name = recipe.Name,
                Description = recipe.Description,
                Amount = recipe.Amount,
                Value = recipe.Value,
                AmountType = recipe.AmountType
            };

            Inventory.Add(craftedItem);

            return craftedItem;
        }

        public string Information()
        {
            return $"{name} {Currency.ToString("c")}";
        }
    }

}
