namespace Inventory.Models;

public class Supplier
{
    public int SupplierID { get; set; }

    /// <summary>
    /// It is a Name of the Supplier
    /// </summary>
    public string? SupplierName { get; set; }

    public string? ContactPerson { get; set; }

    public string? Email { get; set; }
}
