/*IUnitOfWork.cs
DESKTOP-EUQ638R\YMYKHAILOV
*/

namespace JekaWebAPI2.UnitOfWork
{
    using JekaWebAPI2.Interfaces;
    using System;

    /// <summary>
    /// Defines the <see cref="IUnitOfWork" />
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gets the Products
        /// </summary>
        IProductRepository Products { get; }

        /// <summary>
        /// The Save
        /// </summary>
        void Save();
    }
}
