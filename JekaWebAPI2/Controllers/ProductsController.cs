using Microsoft.AspNetCore.Mvc;
using JekaWebAPI2.UnitOfWork;

namespace JekaWebAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult GetProducts() => Ok(_unitOfWork.Products.GetAll());


    }
}
