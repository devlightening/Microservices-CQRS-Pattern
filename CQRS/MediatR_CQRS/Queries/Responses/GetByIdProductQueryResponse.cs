namespace ProductAPI.MediatR_CQRS.Queries.Responses
{
    public class GetByIdProductQueryResponse
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Quantity { get; set; }

    }
}
