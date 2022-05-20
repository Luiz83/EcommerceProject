namespace EcommerceProject.Lib.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

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