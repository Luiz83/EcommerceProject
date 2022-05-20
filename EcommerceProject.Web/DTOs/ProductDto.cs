namespace EcommerceProject.Web.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
        public bool Wireless { get; set; }
    }
}
