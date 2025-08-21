using MediatR;
using ProductAPI.MediatR_CQRS.Queries.Responses;

namespace ProductAPI.MediatR_CQRS.Queries.Requests
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
