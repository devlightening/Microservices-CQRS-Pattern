using MediatR;
using ProductAPI.MediatR_CQRS.Queries.Requests;
using ProductAPI.MediatR_CQRS.Queries.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(p => new GetAllProductQueryResponse
            {
                ProductId = p.ProductId ,
                CreatedDate = p.CreatedDate,
                Description = p.Description,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
            }).ToList();
        }
    }
}

