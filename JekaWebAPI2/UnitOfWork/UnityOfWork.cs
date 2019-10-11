using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JekaWebAPI2.Interfaces;
using JekaWebAPI2.Poco;
using JekaWebAPI2.Repositories;

namespace JekaWebAPI2.UnitOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly CampregistrationContext _db;
        public UnityOfWork(CampregistrationContext db)
        {
            _db = db;
            Products = new ProductRepository(_db);
        }
        public IProductRepository Products { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void save()
        {
            _db.SaveChanges();

        }
    }
}
