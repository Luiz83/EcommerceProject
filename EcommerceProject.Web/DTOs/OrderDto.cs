using EcommerceProject.Lib.Models;

namespace EcommerceProject.Web.DTOs
{
    public class OrderDto
    {
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}