namespace Inventory.Models;

public class Product
{
    public int ProductId { get; set; }

    /// <summary>
    /// It is a Name of the product
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// It is a Detailed description of the product.
    /// </summary>
    public string? Description { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string? Category { get; set; }

}
