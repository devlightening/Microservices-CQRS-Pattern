using MediatR;
using ProductAPI.MediatR_CQRS.Queries.Requests;
using ProductAPI.MediatR_CQRS.Queries.Responses;
using ProductAPI.Models.Context;

namespace ProductAPI.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.ProductId == request.ProductId);
            return new GetByIdProductQueryResponse
            {
                ProductId = product.ProductId,
                CreatedDate = product.CreatedDate,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
            };
        }
    }
}
