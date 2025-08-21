using MediatR;
using ProductAPI.MediatR_CQRS.Commands.Requests;
using ProductAPI.MediatR_CQRS.Commands.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.MediatR_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler :IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
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
