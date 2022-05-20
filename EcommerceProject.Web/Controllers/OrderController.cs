using Microsoft.AspNetCore.Mvc;
using EcommerceProject.Lib.Models;
using EcommerceProject.Web.DTOs;

namespace EcommerceProject.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    public static Client Cliente { get; set; } = new Client("Luiz", "teste@email.com", "senhaSecreta", "444-555-444-45", "Rua dos Bobos, 0");
    public static Order Order { get; set; } = new Order(Cliente, "Pendente", DateTime.Now);
    public static List<Product> OnSale { get; set; } = new List<Product>()
    { new Mouse(1, "MouseRuim", "MarcaUm", "Mouse abaixo da média", 30, 5, false, 800),
      new Mouse(2, "MouseMedio", "MarcaDois", "Mouse na média", 100, 7, false, 2400),
      new Mouse(3, "MouseBom", "MarcaDois", "Mouse acima da média", 200, 2, true, 12000),
      new Keyboard(4, "TecladoRuim", "MarcaUm", "Teclado abaixo da média", 100, 3, false, false),
      new Keyboard(5, "TecladoBom", "MarcaTres", "Teclado acima da média", 500, 1, true, true),
      new Headset(6, "HeadsetMedio", "MarcaDois", "Headset na média", 250, 2, false, true),
      new Headset(7, "HeadsetBom", "MarcaTres", "Headset acima da média", 400, 1, true, true)
    };

    [HttpGet("Itens a Venda")]
    public IActionResult OnSaleApi()
    {
        return Ok(OnSale);
    }

    [HttpGet("Pedido Atual")]
    public IActionResult CurrentOrder()
    {
        return Ok(Order);
    }

    [HttpGet("Finalizar Pedido")]
    public IActionResult CompleteOrder()
    {
        Order.CompleteOrder();
        return Ok(Order);
    }

    [HttpPost("Adicionar um item ao pedido")]
    public IActionResult AddProductToOrder(int id)
    {
        var product = OnSale.Find(p => p.Id == id);
        Order.AddProduct(product);
        return Ok(Order.Products);
    }

    [HttpDelete("Remover um item do pedido")]
    public IActionResult RemoveProductFromOrder(int id)
    {
        var product = Order.Products.Find(p => p.Id == id);
        Order.RemoveProduct(product);
        return Ok(Order.Products);
    }

    [HttpPost("Reiniciar Pedido")]
    public IActionResult NewOrder()
    {
        Order = new Order(Cliente, "Pendente", DateTime.Now);
        return Ok(Order);
    }

}
