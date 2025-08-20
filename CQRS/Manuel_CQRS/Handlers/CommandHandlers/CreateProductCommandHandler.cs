using ProductAPI.Manuel_CQRS.Commands.Requests;
using ProductAPI.Manuel_CQRS.Commands.Responses;
using ProductAPI.Models.Context;
using ProductAPI.Models.Entites;
using System.Xml.Linq;

namespace ProductAPI.Manuel_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                ProductId = id,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                CreatedDate = request.CreatedDate,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true,
            };

        }
    }
}
