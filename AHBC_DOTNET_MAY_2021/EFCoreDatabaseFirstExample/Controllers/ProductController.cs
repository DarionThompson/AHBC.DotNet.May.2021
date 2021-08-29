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

        public async Task<IActionResult> Create(Product product)
        {
            await _productRepository.CreateProduct(product);
            return RedirectToAction("Index");
        }

        //[Route("Product/Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productRepository.FindProductAsync(id);
            return View(product);
        }

        public async Task<IActionResult> EditProduct(Product product)
        {
            await _productRepository.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await _productRepository.DeleteProduct(productId);
            return RedirectToAction("Index");
        }
    }
}
