using JekaWebAPI2.Interfaces;
using System;

namespace JekaWebAPI2.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository Products { get;  }

        void Save();
    }
}
