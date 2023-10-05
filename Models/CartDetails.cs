using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lappy.Models
{
    [Table("CartDetails")]
    public class CartDetails
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int LaptopId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [ForeignKey("LaptopModelId")]
        public LaptopModel LaptopModel { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}