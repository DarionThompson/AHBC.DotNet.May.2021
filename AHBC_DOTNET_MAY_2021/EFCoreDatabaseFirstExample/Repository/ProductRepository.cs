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
        public async Task<List<Product>> GetProductAsync()
        {
            var products = await _northwindContext.Products.ToListAsync();

            return products;
        }
    }
}
