using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BClone.Models;
using BClone.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BClone.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly JsonFileProductService jsonFileProductService;
        public IEnumerable<Product> Products { get;private set; }
        public IndexModel(ILogger<IndexModel> logger,JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            this.jsonFileProductService = jsonFileProductService;
        }

        public void OnGet()
        {
            Products = jsonFileProductService.GetProducts();
        }
    }
}
