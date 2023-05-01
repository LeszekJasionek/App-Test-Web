using App_Test_Web.Models;
using App_Test_Web.Services.Interfaces;

namespace App_Test_Web.Services
{
    public class WarehouseService : IWarehouseService
    {

        private readonly DbTestContext _context;


        public WarehouseService(DbTestContext context)
        {
            _context = context;
        }

        public int Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return id;
        }

        public List<Product> GetAll()
        {
            var productList = _context.Products.ToList();
            return productList;
        }

        public Product GetSingle(int id)
        {
            var productId = _context.Products.Find(id);
            return productId;
        }

        public int Save(Product product)
        {
            _context.Products.Add(product);

            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("Success");
            };

            // business logica dat de gegevens in de database opslaat
            return product.Id;
        }
    }
}
