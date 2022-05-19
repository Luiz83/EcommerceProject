namespace EcommerceProject.Lib.Models
{
    public class Product
    {
        private string Name { get; set; }
        private string Brand { get; set; }
        private string Description { get; set; }
        private double Value { get; set; }
        private int Quantity { get; set; }
        public bool Wireless { get; set; }

        public Product(string name, string brand, string description, double value, int quantity, bool wireless)
        {
            SetName(name);
            SetBrand(brand);
            SetDescription(description);
            SetValue(value);
            SetQuantity(quantity);
            SetWireless(wireless);
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetBrand(string brand)
        {
            Brand = brand;
        }
        public string GetBrand()
        {
            return Brand;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetValue(double value)
        {
            Value = value;
        }
        public double GetValue()
        {
            return Value;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public void SetWireless(bool wireless)
        {
            Wireless = wireless;
        }
        public bool GetWireless()
        {
            return Wireless;
        }
    }
}