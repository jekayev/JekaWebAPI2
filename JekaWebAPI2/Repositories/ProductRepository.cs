using JekaWebAPI2.Interfaces;
using JekaWebAPI2.Poco;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JekaWebAPI2.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly CampregistrationContext _db;
        public ProductRepository(CampregistrationContext db): base(db)
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
