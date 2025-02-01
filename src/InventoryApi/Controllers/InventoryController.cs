using Inventory.Models;
using InventoryApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApi.Controllers;

[ApiController]
[Route("[controller]")]
public class InventoryController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<InventoryController> _logger;
    private readonly IInventoryService _inventoryService;

    public InventoryController(ILogger<InventoryController> logger,
    IInventoryService inventoryService)
    {
        _logger = logger;
        _inventoryService = inventoryService;
    }

    [HttpGet(Name = "GetInventory")]
    public IEnumerable<Product> Get()
    {
       return _inventoryService.GetProducts("laptops");
    }
}
