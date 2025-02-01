using Inventory.Models;

namespace InventoryApi.Services;

public class InventoryService : IInventoryService
{
    public IEnumerable<Product> GetProducts(string? input)
    {
        return GetProductsFromRepo();
    }

    private IEnumerable<Product> GetProductsFromRepo()
    {

        var product1 = new Product(){
            ProductId = 101,
            Title = "Lenovo IdeaPad 1 Student Laptop, 15.6\" FHD Display, Intel Dual Core Processor, 12GB RAM, 512GB SSD + 128GB eMMC, 1 Year Office 365, Wi-Fi 6, Webcam, Bluetooth, SD Card Reader, Windows 11 Home, Grey",
            Description = "[High Speed RAM And Enormous Space] 12GB high-bandwidth RAM to smoothly run multiple applications and browser tabs all at once; 512GB PCIe NVMe M.2 Solid State Drive + 128GB eMMC allows to fast bootup and data transfer",
            Price = 339.00,
            Quantity = 10,            
        };
        var product2 = new Product(){
            ProductId = 102,
            Title = "Philips Norelco Multi Groomer All-in-One Trimmer Series 3000-13 Piece Mens Grooming Kit for Beard, Face, Nose, Ear Hair Trimmer and Hair Clipper - NO Blade Oil Needed, MG3740/40",
            Description = "13 pieces for all of your grooming needs: Beard and stubble trimming and maintenance, precision trimmer allows exact placement for sharp lines, nose and ear trimmer taking care of unwanted hairs",
            Price = 19.00,
            Quantity = 20,            
        };

        var productList = new List<Product>
        {
            product1,
            product2
        };

        return productList;
    }
}