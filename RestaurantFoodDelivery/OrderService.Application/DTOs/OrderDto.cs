namespace OrderService.Application.DTOs
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }

        public decimal TotalAmount { get; set; }

        public IEnumerable<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }
}
