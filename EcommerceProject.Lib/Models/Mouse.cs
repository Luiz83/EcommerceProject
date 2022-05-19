namespace EcommerceProject.Lib.Models
{
    public class Mouse : Product
    {
        private int Dpi { get; set; }

        public Mouse(string name, string brand, string description, double value, int quantity, bool wireless, int dpi)
                    : base(name, brand, description, value, quantity, wireless)
        {
            SetDpi(dpi);
        }

        public void SetDpi(int dpi)
        {
            Dpi = dpi;
        }
        public int GetDpi()
        {
            return Dpi;
        }
    }
}