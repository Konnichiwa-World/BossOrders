using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BossOrders.Entities { 

    [Table("Orders")]
public class Order
{
    [Key]
    public Guid Id { get; set; }
        [Required]
    [StringLength(500)]
    public string BossOrder { get; set; }
    //public DateTime CreatedAt { get; set; } = DateTime.Now;

}
}