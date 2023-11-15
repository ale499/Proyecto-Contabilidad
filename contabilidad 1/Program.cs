using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace contabilidad_1
{
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.Web3;

class Program
{
    static async Task Main()
    {
        // Configuración del nodo Ethereum 
        var ethereumNodeUrl = "http://localhost:8545";
        var blockchainService = new BlockchainService(ethereumNodeUrl);

        // Crear algunos productos
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.5m },
            new Product { Id = 2, Name = "Product 2", Price = 20.0m }
        };

        // Crear un cliente
        var customer = new Customer { Id = 1, Name = "Pedro sanchez" };

        // Crear una venta
        var sale = new Sale
        {
            Id = 1,
            Customer = customer,
            Products = new List<Product> { products[0], products[1] }
        };

        // Calcular el total de la venta
        sale.TotalAmount = CalculateTotalAmount(sale.Products);

        // Imprimir la información de la venta
        Console.WriteLine($"Venta ID: {sale.Id}");
        Console.WriteLine($"Cliente: {sale.Customer.Name}");
        Console.WriteLine("Productos:");
        foreach (var product in sale.Products)
        {
            Console.WriteLine($"  - {product.Name}: ${product.Price}");
        }
        Console.WriteLine($"Total: ${sale.TotalAmount}");

        // Obtener el saldo de la dirección Ethereum 
        var ethereumAddress = "0xYourEthereumAddress";
        var balance = await blockchainService.GetBalanceAsync(ethereumAddress);

        Console.WriteLine($"Saldo en Ethereum: {balance} ETH");
    }

    static decimal CalculateTotalAmount(List<Product> products)
    {
        return products.Sum(p => p.Price);
    }
}

public class BlockchainService
{
    private readonly string ethereumNodeUrl;

    public BlockchainService(string nodeUrl)
    {
        ethereumNodeUrl = nodeUrl;
    }

    public async Task<decimal> GetBalanceAsync(string address)
    {
        var web3 = new Web3(ethereumNodeUrl);
        var balanceWei = await web3.Eth.GetBalance.SendRequestAsync(address);
        var balanceEther = Web3.Convert.FromWei(balanceWei);
        return balanceEther;
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Sale
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalAmount { get; set; }
}

}