namespace EcommerceProject.Lib.Models
{
    public class Admin : User
    {
        private string Cnpj { get; set; }
        public Admin(string name, string email, string password, string cnpj) : base(name, email, password)
        {
            SetCnpj(cnpj);
        }
        public void SetCnpj(string cnpj)
        {
            Cnpj = cnpj;
        }
        public string GetCnpj()
        {
            return Cnpj;
        }
    }
}