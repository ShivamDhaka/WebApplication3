namespace WebApplication3.Models
{
    public class Inventory
    {
        //Name, Details, QtyInStock,LastUpdated
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int QtyInStock { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Supplier supplier { get; set; }
    }
}
