using System;
using System.Collections.Generic;

namespace CraftSystem
{
    public class Person
    {
        private string personName;
        private double Currency = 10.50;
        private List<Item> inventory;

        // Constructor
        public Person(string name)
        {
            personName = name;
            inventory = new List<Item>();
        }

        // Method to get player information
        public string Information()
        {
            return $"{personName} has {Currency.ToString("C")}";
        }

        // Method to update player name
        public void UpdateName(string newName)
        {
            personName = newName;
        }

        // Method to add an item to the inventory
        public void AddItemToInventory(Item item)
        {
            inventory.Add(item);
        }

        // Method to display inventory items
        public void DisplayInventory()
        {
            Console.WriteLine($"{personName}'s Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"- {item.Name} ({item.Amount} {item.AmountType}) worth {item.Value:C}");
            }
        }
    }
}
