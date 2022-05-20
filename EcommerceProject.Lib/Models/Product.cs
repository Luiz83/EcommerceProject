namespace EcommerceProject.Lib.Models
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Brand { get; set; }
        private string Description { get; set; }
        protected double Value { get; set; }
        private int Quantity { get; set; }
        protected bool Wireless { get; set; }

        public Product(string name, string brand, string description, double value, int quantity, bool wireless)
        {
            SetName(name);
            SetBrand(brand);
            SetDescription(description);
            SetQuantity(quantity);
            SetWireless(wireless);
            SetValue(CalcValue(value));
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
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
        public virtual double CalcValue(double value)
        {
            return Value;
        }
        public void AddQuantity(int qnt)
        {
            Quantity = Quantity + qnt;
        }
        public void RemoveQuantity(int qnt)
        {
            Quantity = Quantity - qnt;
        }
    }
}