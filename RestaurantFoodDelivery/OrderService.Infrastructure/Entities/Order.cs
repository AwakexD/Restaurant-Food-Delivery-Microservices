using System.ComponentModel.DataAnnotations.Schema;

namespace OrderService.Infrastructure.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        public virtual ICollection<OrderItem>? Items { get; set; }
    }
}
