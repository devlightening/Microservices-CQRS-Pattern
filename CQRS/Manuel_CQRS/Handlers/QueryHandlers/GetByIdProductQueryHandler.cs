using ProductAPI.Manuel_CQRS.Queries.Requests;
using ProductAPI.Manuel_CQRS.Queries.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.Manuel_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(x => x.ProductId == request.ProductId);
            if (product != null)
            {
                return new GetByIdProductQueryResponse
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    CreatedDate = product.CreatedDate,
                    Quantity = product.Quantity
                };
            }
            else
            {
                return null; // or throw an exception, depending on your error handling strategy
            }
        }

    }
}
