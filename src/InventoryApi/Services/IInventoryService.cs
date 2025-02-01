using Inventory.Models;

namespace InventoryApi.Services;

public interface IInventoryService{
    IEnumerable<Product> GetProducts(string? input);    
}