using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController()
        {
            _productService = new ProductManager(new InMemoryProductDal());
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           var result = _productService.GetAll();
           return Ok(result);
        }


        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _productService.GetAllByName(name.ToLower());
            return Ok(result);
        }
    }
}
