namespace EcommerceProject.Lib.Models
{
    public class Headset : Product
    {
        private bool Surround { get; set; }

        public Headset(string name, string brand, string description, double value, int quantity, bool wireless, bool surround)
                    : base(name, brand, description, value, quantity, wireless)
        {
            SetSurround(surround);
        }

        public void SetSurround(bool surround)
        {
            Surround = surround;
        }
        public bool GetSurround()
        {
            return Surround;
        }
        public override double CalcValue(double value)
        {
            if (Surround && Wireless)
            {
                value = value + 500;
            }
            else if (Surround || Wireless)
                value = value + 150;
            return value;
        }
    }
}