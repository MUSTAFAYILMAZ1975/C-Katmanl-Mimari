using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
            //Loosely coupled
            //naming convention
            //IoC Container -- Inversion of Control
           private IProductService _productService;

            public ProductsController(IProductService productService)
            {
                _productService = productService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                //Swagger
                //Dependency chain --

                // Thread.Sleep(1000);

                var result = _productService.GetAll();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);

            }
        [HttpGet("getlist")]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetList()
        {

            var result = _productService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
    
}
