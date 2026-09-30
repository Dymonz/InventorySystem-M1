using Microsoft.AspNetCore.Mvc;
using InventoryAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Laptop Pro", Code = "LP-001", Brand = "TechCorp", UnitPrice = 1200.00m },
            new Item { Id = 2, Name = "Wireless Mouse", Code = "WM-002", Brand = "LogiTech", UnitPrice = 25.50m }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems() => Ok(items);

        [HttpPost]
        public ActionResult<Item> CreateItem([FromBody] Item newItem)
        {
            newItem.Id = items.Count > 0 ? items.Max(i => i.Id) + 1 : 1;
            items.Add(newItem);
            return CreatedAtAction(nameof(GetItems), new { id = newItem.Id }, newItem);
        }
    }
}