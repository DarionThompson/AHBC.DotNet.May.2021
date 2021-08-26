using EFCoreDatabaseFirstExample.Models;
using EFCoreDatabaseFirstExample.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDatabaseFirstExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            //Here 
            var model = await _productRepository.GetProductAsync();
            return View(model);
        }
    }
}
