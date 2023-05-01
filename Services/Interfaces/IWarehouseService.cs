using App_Test_Web.Models;

namespace App_Test_Web.Services.Interfaces
{
    public interface IWarehouseService
    {
        int Save(Product product);

        List<Product> GetAll();

    }
}
