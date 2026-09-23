using System;

namespace TechVault.API.Models
{
    public class InventoryTransaction
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Type { get; set; } = string.Empty;
        public int QuantityChanged { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string Remarks { get; set; } = string.Empty;

        public Item? Item { get; set; }
    }
}
