using WebApplication3.Models;

namespace WebApplication3
{
    public interface IInventory
    {
        List<Inventory> GetDetails();
        Inventory Create(Inventory inventory);
        Inventory GetUserById(int id);
        int edit(int id, Inventory supplier);
        int Delete(int id);
    }
}
