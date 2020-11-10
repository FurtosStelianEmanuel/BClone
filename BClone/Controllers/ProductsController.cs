using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BClone.Models;
using BClone.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BClone.Controllers
{


    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        JsonFileProductService jsonFileProductService { get; }
        public ProductsController(JsonFileProductService jsonFileProductService)
        {
            this.jsonFileProductService = jsonFileProductService;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return jsonFileProductService.GetProducts();
        }

    }

   
}
