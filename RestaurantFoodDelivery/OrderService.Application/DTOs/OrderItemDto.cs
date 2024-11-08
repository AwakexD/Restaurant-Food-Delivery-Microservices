namespace OrderService.Application.DTOs
{
    public class OrderItemDto
    {
        public Guid OrderItemId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }
}
