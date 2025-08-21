using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Manuel_CQRS.Commands.Requests;
using ProductAPI.Manuel_CQRS.Handlers.CommandHandlers;
using ProductAPI.Manuel_CQRS.Handlers.QueryHandlers;
using ProductAPI.Manuel_CQRS.Queries.Requests;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    #region "Manuel_CQRS"

    public class ProductController(
    CreateProductCommandHandler createProductCommandHandler,
    DeleteProductCommandHandler deleteProductCommandHandler,
    GetAllProductQueryHandler getAllProductQueryHandler,
    GetByIdProductQueryHandler getByIdProductQueryHandler) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] GetAllProductQueryRequest request)
            => Ok(getAllProductQueryHandler.GetAllProduct(request));


        [HttpGet("{productId}")]
        public IActionResult GetProductById([FromQuery] GetByIdProductQueryRequest request)
            => Ok(getByIdProductQueryHandler.GetByIdProduct(request));

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateProductCommandRequest request)
             => Ok(createProductCommandHandler.CreateProduct(request));

        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct([FromQuery] DeleteProductCommandRequest request)
             => Ok(deleteProductCommandHandler.DeleteProduct(request));
    }
    #endregion

    [Route("api/[controller]")]
    [ApiController]

    public class ProductController(MediatR mediatR)
}
