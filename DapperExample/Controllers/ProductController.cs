using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DapperExample.Domain.Models;
using DapperExample.Application.Queries;

namespace DapperExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetProducts")]
        public async Task<List<Product>> GetSignatures()
        {
            var query = new GetAllProductsQuery();
            List<Product> getSignatureResult = await _mediator.Send(query);

            return getSignatureResult;
        }
    }
}
