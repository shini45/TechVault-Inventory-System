using TechVault.API.Models;

namespace TechVault.API.Data
{
    public static class ItemData
    {
        public static List<Item> Items = new List<Item>
        {
            new Item
            {
                Id = 1,
                Name = "Gaming Laptop",
                Code = "TV-LAP-001",
                Brand = "ASUS",
                Category = "Laptop",
                StockQuantity = 10,
                UnitPrice = 65000
            },

            new Item
            {
                Id = 2,
                Name = "Mechanical Keyboard",
                Code = "TV-KEY-002",
                Brand = "Logitech",
                Category = "Keyboard",
                StockQuantity = 25,
                UnitPrice = 3500
            },

            new Item
            {
                Id = 3,
                Name = "Wireless Mouse",
                Code = "TV-MOU-003",
                Brand = "Razer",
                Category = "Mouse",
                StockQuantity = 15,
                UnitPrice = 2500
            },

            new Item
            {
                Id = 4,
                Name = "27-inch Monitor",
                Code = "TV-MON-004",
                Brand = "Samsung",
                Category = "Monitor",
                StockQuantity = 8,
                UnitPrice = 14500
            },

            new Item
            {
                Id = 5,
                Name = "RTX 4070 Graphics Card",
                Code = "TV-GPU-005",
                Brand = "NVIDIA",
                Category = "Accessories",
                StockQuantity = 5,
                UnitPrice = 35000
            }
        };
    }
}
