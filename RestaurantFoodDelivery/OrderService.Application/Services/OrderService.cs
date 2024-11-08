using OrderService.Application.DTOs;

namespace OrderService.Application.Services
{
    public class OrderService : IOrderService
    {
        public Task<OrderDto> CreateOrderAsync(OrderDto orderDto)
        {
            throw new NotImplementedException();
        }
    }
}
