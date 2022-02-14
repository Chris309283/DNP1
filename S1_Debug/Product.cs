namespace S1_Debug;

public class Product
{
    public Product(string name, Category category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
    }

    public string Name { get; set; }
    public Category Category { get; set; }
    public double Price { get; set; }
}