using WebApplication3.Models;

namespace WebApplication3
{
    public interface ISupplier
    {
        List<Supplier> GetDetails();
        Supplier Create(Supplier supplier);
        Supplier GetUserById(int id);
        int edit(int id, Supplier supplier);
        int Delete(int id);

    }
}
