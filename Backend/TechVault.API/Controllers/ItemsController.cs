using Microsoft.AspNetCore.Mvc;
using TechVault.API.Data;
using TechVault.API.Models;

namespace TechVault.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Item>> GetItems()
        {
            return Ok(ItemData.Items);
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = ItemData.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public ActionResult<Item> AddItem(Item item)
        {
            item.Id = ItemData.Items.Count + 1;
            ItemData.Items.Add(item);

            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult<Item> UpdateItem(int id, Item updatedItem)
        {
            var item = ItemData.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            item.Name = updatedItem.Name;
            item.Code = updatedItem.Code;
            item.Brand = updatedItem.Brand;
            item.Category = updatedItem.Category;
            item.StockQuantity = updatedItem.StockQuantity;
            item.UnitPrice = updatedItem.UnitPrice;

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            var item = ItemData.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            ItemData.Items.Remove(item);

            return NoContent();
        }
    }
}
