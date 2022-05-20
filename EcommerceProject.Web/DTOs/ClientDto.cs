namespace EcommerceProject.Web.DTOs
{
    public class ClientDto : UserDto
    {
        public string Cpf { get; set; }
        public string Address { get; set; }
    }
}