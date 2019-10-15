using JekaWebAPI2.Interfaces;
using JekaWebAPI2.Poco;
using System.Linq;

namespace JekaWebAPI2.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly CampregistrationContext _db;

        public ProductRepository(CampregistrationContext db) : base(db)
        {
            _db = db;
        }

        public Product GetProductList()
        {
            return _db.Products.FirstOrDefault();
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.ProductId == product.ProductId);

            objFromDb.Name = product.Name;
            objFromDb.ProductIndex = product.ProductIndex;

            _db.SaveChanges();
        }
    }
}