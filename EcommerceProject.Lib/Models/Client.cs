namespace EcommerceProject.Lib.Models
{
    public class Client : User
    {
        public string Cpf { get; set; }
        public string Address { get; set; }

        public Client(string name, string email, string password, string cpf, string address) : base(name, email, password)
        {
            SetCpf(cpf);
            SetAddress(address);
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        public string GetAddress()
        {
            return Address;
        }
    }
}