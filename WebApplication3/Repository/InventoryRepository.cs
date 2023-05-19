using WebApplication3.Context;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class InventoryRepository : IInventory
    {
        UseDbContext _db;
        public InventoryRepository(UseDbContext db)
        {
            _db = db;
        }
        public Inventory Create(Inventory inventory)
        {
            _db.Inventories.Add(inventory);
            _db.SaveChanges();
            return inventory;
        }

        public int Delete(int id)
        {
            Inventory obj = GetUserById(id);
            if(obj != null)
            {
                _db.Inventories.Remove(obj);
                _db.SaveChanges();
            }
            return 0;
        }

        public int edit(int id, Inventory supplier)
        {
            Inventory IObj = GetUserById(id);
            if(IObj != null)
            {
                foreach(Inventory i in _db.Inventories)
                {
                    if(i.Id == id)
                    {
                        i.QtyInStock = supplier.QtyInStock;
                    }
                }
            }
            return 0;
        }

        public List<Inventory> GetDetails()
        {
            return _db.Inventories.ToList();
        }

        public Inventory GetUserById(int id)
        {
            return _db.Inventories.FirstOrDefault(x => x.Id == id);
        }
    }
}
