using MediatR;
using ProductAPI.MediatR_CQRS.Queries.Responses;

namespace ProductAPI.MediatR_CQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid ProductId { get; set; }
    }
}
