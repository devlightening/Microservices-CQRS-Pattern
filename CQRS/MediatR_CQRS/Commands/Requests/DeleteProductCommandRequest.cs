using MediatR;
using ProductAPI.MediatR_CQRS.Commands.Responses;

namespace ProductAPI.MediatR_CQRS.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
       
    }
}
