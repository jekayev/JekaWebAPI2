/*UnitOfWork.cs
DESKTOP-EUQ638R\YMYKHAILOV
*/

namespace JekaWebAPI2.UnitOfWork
{
    using JekaWebAPI2.Interfaces;
    using JekaWebAPI2.Poco;
    using JekaWebAPI2.Repositories;

    /// <summary>
    /// Defines the <see cref="UnitOfWork" />
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Defines the _db
        /// </summary>
        private readonly CampregistrationContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="db">The db<see cref="CampregistrationContext"/></param>
        public UnitOfWork(CampregistrationContext db)
        {
            _db = db;
            Products = new ProductRepository(_db);
        }

        /// <summary>
        /// Gets the Products
        /// </summary>
        public IProductRepository Products { get; private set; }

        /// <summary>
        /// The Dispose
        /// </summary>
        public void Dispose()
        {
            _db.Dispose();
        }

        /// <summary>
        /// The Save
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
