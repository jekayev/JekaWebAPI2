using JekaWebAPI2.Interfaces;
using JekaWebAPI2.Poco;
using JekaWebAPI2.Repositories;

namespace JekaWebAPI2.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CampregistrationContext _db;
        public UnitOfWork(CampregistrationContext db)
        {
            _db = db;
            Products = new ProductRepository(_db);
        }
        public IProductRepository Products { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();

        }
    }
}
