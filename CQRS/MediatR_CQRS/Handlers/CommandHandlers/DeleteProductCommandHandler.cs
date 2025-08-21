using MediatR;
using ProductAPI.MediatR_CQRS.Commands.Requests;
using ProductAPI.MediatR_CQRS.Commands.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.MediatR_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.ProductId == request.ProductId);
            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
                return new DeleteProductCommandResponse
                {
                    IsSuccess = true,
                    Message = "Product deleted successfully."
                };
            }
            else
            {
                return new DeleteProductCommandResponse
                {
                    IsSuccess = false,
                    Message = "Product not found."
                };
            }

        }
    }
}
