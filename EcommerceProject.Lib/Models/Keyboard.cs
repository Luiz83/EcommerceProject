namespace EcommerceProject.Lib.Models
{
    public class Keyboard : Product
    {
        private bool Mechanical { get; set; }

        public Keyboard(string name, string brand, string description, double value, int quantity, bool wireless, bool mechanical)
                    : base(name, brand, description, value, quantity, wireless)
        {
            SetMechanical(mechanical);
        }

        public void SetMechanical(bool mechanical)
        {
            Mechanical = mechanical;
        }
        public bool GetMechanical()
        {
            return Mechanical;
        }
    }
}