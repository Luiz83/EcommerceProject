namespace EcommerceProject.Lib.Models
{
    public class User
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }

        public User(string name, string email, string password)
        {
            SetName(name);
            SetEmail(email);
            SetPassword(password);
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
        public string GetPassword()
        {
            return Password;
        }
    }
}