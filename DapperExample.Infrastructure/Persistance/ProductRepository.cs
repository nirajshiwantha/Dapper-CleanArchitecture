using DapperExample.Application.Persistance;
using DapperExample.Domain.Models;
using DapperExample.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample.Infrastructure.Persistance
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperexampleDbContext _dapperexampleDbContext;

        public ProductRepository(DapperexampleDbContext dapperexampleDbContext)
        {
            _dapperexampleDbContext = dapperexampleDbContext;
        }

        public async Task<List<Product>> GetAll()
        {
            var products = await _dapperexampleDbContext.products.ToListAsync();

            if (products == null || products.Count == 0)
            {
                throw new InvalidOperationException("No Products found");
            }

            return products;
        }
    }
}
