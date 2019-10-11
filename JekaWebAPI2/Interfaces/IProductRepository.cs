using JekaWebAPI2.Poco;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JekaWebAPI2.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductList();

        void Update(Product product);
    }
}
