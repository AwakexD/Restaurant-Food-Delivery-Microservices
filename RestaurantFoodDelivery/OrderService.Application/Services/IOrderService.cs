using OrderService.Application.DTOs;

namespace OrderService.Application.Services
{
    public interface IOrderService
    {
        Task<OrderDto> CreateOrderAsync(OrderDto orderDto);
    }
}
