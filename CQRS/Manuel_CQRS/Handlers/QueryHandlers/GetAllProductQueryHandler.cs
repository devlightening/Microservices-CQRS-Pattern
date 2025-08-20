using ProductAPI.Manuel_CQRS.Queries.Requests;
using ProductAPI.Manuel_CQRS.Queries.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.Manuel_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
        {
            return ApplicationDbContext.ProductList.Select(x => new GetAllProductQueryResponse
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                CreatedDate = x.CreatedDate,
                Quantity = x.Quantity
            }).ToList(); 

        }
    }
}
