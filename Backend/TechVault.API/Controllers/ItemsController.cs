using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechVault.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechVault.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public ItemsController(InventoryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Item>> AddItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, Item updatedItem)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();

            item.Name = updatedItem.Name;
            item.Code = updatedItem.Code;
            item.Brand = updatedItem.Brand;
            item.Category = updatedItem.Category;
            item.StockQuantity = updatedItem.StockQuantity;
            item.UnitPrice = updatedItem.UnitPrice;

            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpPut("{id}/restock")]
        public async Task<IActionResult> Restock(int id, [FromBody] int addQty)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();

            item.StockQuantity += addQty;
            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpPut("{id}/stock-out")]
        public async Task<IActionResult> StockOut(int id, [FromBody] int deductQty)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();
            if (item.StockQuantity < deductQty) return BadRequest("Insufficient product inventory capacity stock parameters.");

            item.StockQuantity -= deductQty;
            await _context.SaveChangesAsync();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
