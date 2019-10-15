/*IProductRepository.cs
DESKTOP-EUQ638R\YMYKHAILOV
*/

namespace JekaWebAPI2.Interfaces
{
    using JekaWebAPI2.Poco;

    /// <summary>
    /// Defines the <see cref="IProductRepository" />
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        /// <summary>
        /// The GetProductList
        /// </summary>
        /// <returns>The <see cref="Product"/></returns>
        Product GetProductList();

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="product">The product<see cref="Product"/></param>
        void Update(Product product);
    }
}
