using MediatR;
using ProductAPI.MediatR_CQRS.Queries.Requests;
using ProductAPI.MediatR_CQRS.Queries.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>.Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
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

