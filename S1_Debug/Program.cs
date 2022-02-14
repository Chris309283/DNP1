namespace S1_Debug;

public class Program
{
    private static readonly IEnumerable<Product> Products = new List<Product>
    {
        new("Batteries", Category.Electronics, 2.50),
        new("SD Card", Category.Electronics, 10),
        new("T-shirt", Category.Electronics, 15),
        new("Parmesan Cheese", Category.Grocery, 7.50),
        new("Tomatoes", Category.Grocery, 2)
    };

    public static void Main(string[] args)
    {
        ShowPricesWithVat();
    }

    private static void ShowPricesWithVat()
    {
        Console.WriteLine("Product prices incl. VAT:");

        foreach (var product in Products)
        {
            var vat = Utils.CalculateVat(product.Price, product.Category);
            var priceWithVat = Math.Round(product.Price + vat, 2);
            Console.WriteLine($"{product.Name}: {priceWithVat} EUR");
        }
    }
}