using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExample.Domain.Models;
using DapperExample.Application.Persistance;
using Microsoft.Data.SqlClient;
using DapperExample.Application.Abstractions;
using System.Data.Entity.Infrastructure;
using Dapper;

namespace DapperExample.Application.Queries
{
    internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        //private readonly IProductRepository _productRepository;

        //public GetAllProductsQueryHandler(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}

        private readonly ISqlConnectionFactory _sqlConnectionFactory;
public GetAllProductsQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            await using SqlConnection sqlConnection = _sqlConnectionFactory.CreateConnection();
            var products = await sqlConnection.QueryAsync<Product>("SELECT * FROM Products");
            return products.ToList();
        }
    }
}
