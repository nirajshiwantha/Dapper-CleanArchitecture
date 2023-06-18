using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExample.Domain.Models;

namespace DapperExample.Application.Persistance
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
    }
}
