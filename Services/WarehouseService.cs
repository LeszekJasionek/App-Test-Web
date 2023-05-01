using App_Test_Web.Models;
using App_Test_Web.Services.Interfaces;

namespace App_Test_Web.Services
{
    public class WarehouseService : IWarehouseService
    {
        public int Save(Product product)
        {
            // business logica dat de gegevens in de database opslaat
            return 1;
        }
    }
}
