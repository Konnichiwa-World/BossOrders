using System.ComponentModel.DataAnnotations;

namespace BossOrders.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public string BossOrder { get; set; }
        
        //public DateTime CreatedAt { get; set; } = DateTime.Now;

    }

    public class CreateOrderModel
    {
        //[Display(Name ="Kullanıcı Adı", Prompt ="johndoe")]
        [Required(ErrorMessage = "Order is required.")]
        [StringLength(500, ErrorMessage = "Order can be max 500 characters.")]
        public string BossOrder { get; set; }

    }

    public class EditOrderModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Order is required.")]
        [StringLength(500, ErrorMessage = "Order can be max 500 characters.")]
        public string BossOrder { get; set; }
    }
}
