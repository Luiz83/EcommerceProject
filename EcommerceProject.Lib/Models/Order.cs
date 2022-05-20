namespace EcommerceProject.Lib.Models
{
    public class Order
    {
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public Order(Client client, double totalAmount, string status, DateTime date)
        {
            Products = new List<Product>();
            SetClient(client);
            SetTotalAmount(totalAmount);
            SetStatus(status);
            SetDate(date);
        }

        public void SetClient(Client client)
        {
            Client = client;
        }
        public Client GetClient()
        {
            return Client;
        }
        public void SetTotalAmount(Double totalAmount)
        {
            TotalAmount = totalAmount;
        }
        public Double GetTotalAmount()
        {
            return TotalAmount;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            Products.RemoveAll(p => p.GetId == product.GetId);
        }
        public double CompleteOrder(){
            var totalAmount = 0.0;
            foreach (Product product in Products)
            {
                totalAmount = totalAmount + product.GetValue();
            }
            return TotalAmount = totalAmount;
        }
    }
}