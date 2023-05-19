using WebApplication3.Context;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class SupplierRepository : ISupplier
    {
        UseDbContext _db;
        public SupplierRepository(UseDbContext db)
        {
            _db = db;
        }
        public Supplier Create(Supplier supplier)
        {
            _db.Suppliers.Add(supplier);
            _db.SaveChanges();
            return supplier;
        }

        public int Delete(int id)
        {
            Supplier obj = GetUserById(id);
            if(obj != null)
            {
                _db.Suppliers.Remove(obj);
                _db.SaveChanges();
            }
            return 0;
        }

        public int edit(int id, Supplier supplier)
        {
            Supplier SObj = GetUserById(id);
            if(SObj != null)
            {
                foreach (Supplier s in _db.Suppliers)
                {
                    if(s.SupplierId == id)
                    {
                        s.Address = supplier.Address;
                    }
                }
                _db.SaveChanges();
                
            }
            return 0;
        }

        public List<Supplier> GetDetails()
        {
            return _db.Suppliers.ToList();
        }

        public Supplier GetUserById(int id)
        {
            return _db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
        }
    }
}
