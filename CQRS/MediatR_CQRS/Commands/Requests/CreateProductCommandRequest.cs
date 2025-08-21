using MediatR;
using ProductAPI.MediatR_CQRS.Commands.Responses;

namespace ProductAPI.MediatR_CQRS.Commands.Requests
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int Quantity { get; set; } = 1;
    }
}
