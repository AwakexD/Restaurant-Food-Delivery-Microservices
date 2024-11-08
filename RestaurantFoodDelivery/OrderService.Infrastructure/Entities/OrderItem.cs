using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderService.Infrastructure.Entities
{
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }

        [MaxLength(70)]
        public string? ProductName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }  

        public Order? Order { get; set; } 
    }
}
