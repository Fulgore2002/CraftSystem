using System;
using System.Collections.Generic;

namespace CraftSystem
{
    public class Person
    {
        public string Name { get; set; }
        public double Currency { get; set; }
        private List<Item> inventory;

        // Constructor
        public Person(string name, double currency = 10.50)
        {
            Name = name;
            Currency = currency;
            inventory = new List<Item>();
        }

        // Method to get player information
        public string Information()
        {
            return $"{Name} has {Currency:C}";
        }

        // New method to print player's name and currency
        public void PrintStatus()
        {
            Console.WriteLine(Information());
        }

        // Method to update player name
        public void UpdateName(string newName)
        {
            Name = newName;
        }

        // Method to add an item to the inventory
        public void AddItemToInventory(Item item)
        {
            inventory.Add(item);
        }

        // Method to display inventory items
        public void DisplayInventory()
        {
            Console.WriteLine($"{Name}'s Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"- {item.Name} ({item.Amount} {item.AmountType}) worth {item.Value:C}");
            }
        }
    }
}
