using JekaWebAPI2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JekaWebAPI2.UnitOfWork
{
    public interface IUnityOfWork: IDisposable
    {
        IProductRepository Products { get;  }

        void save();
    }
}
