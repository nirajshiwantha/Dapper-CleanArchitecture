using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DapperExample.Domain.Models;

namespace DapperExample.Application.Queries
{
    public record GetAllProductsQuery : IRequest<List<Product>>;
}
