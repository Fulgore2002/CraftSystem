namespace CraftSystem
{
    public class Item
    {
        public string Name;
        public string Description;
        public double Value;
        public double Amount = 1;
        public string AmountType = "cup(s)";

        // Constructor
        public Item(string name, string description, double value, double amount, string amountType)
        {
            Name = name;
            Description = description;
            Value = value;
            Amount = amount;
            AmountType = amountType;
        }

        // Method to display item details
        public string GetDetails()
        {
            return $"{Amount} {AmountType} of {Name} - {Description} (Value: {Value:C})";
        }

        // Method to update item amount
        public void UpdateAmount(double newAmount)
        {
            Amount = newAmount;
        }

        // Method to update item value
        public void UpdateValue(double newValue)
        {
            Value = newValue;
        }
    }
}
