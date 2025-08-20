using ProductAPI.Manuel_CQRS.Commands.Requests;
using ProductAPI.Manuel_CQRS.Commands.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.Manuel_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
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
