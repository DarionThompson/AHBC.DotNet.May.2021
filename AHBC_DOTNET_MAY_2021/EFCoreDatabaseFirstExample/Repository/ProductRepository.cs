using EFCoreDatabaseFirstExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDatabaseFirstExample.Repository
{
    public class ProductRepository
    {
        private readonly NorthwindContext _northwindContext;

        public ProductRepository(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        //C.R.U.D
        //Read

        public async Task CreateProduct(Product product)
        {
            //What happens if the product exists ?
            var foundProduct = _northwindContext.Products.Any(x => x.ProductId == product.ProductId);
            if (!foundProduct)
            {
                await _northwindContext.AddAsync(product);
                await _northwindContext.SaveChangesAsync();
            }
        }
        public async Task<List<Product>> GetProductAsync()
        {
            var products = await _northwindContext.Products.ToListAsync();

            return products;
        }

        public async Task<Product> FindProductAsync(int productId)
        {
            var product = await _northwindContext.Products.FindAsync(productId);
            return product;
        }

        public async Task UpdateProduct(Product product)
        {
            
            _northwindContext.Update(product);
            //If you dont do this, your command wont stick
            await _northwindContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var product = await FindProductAsync(productId);
            _northwindContext.Remove(product);
            await _northwindContext.SaveChangesAsync();
        }
    }
}
