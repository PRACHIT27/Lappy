using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lappy.Models
{
    [Table("Laptops")]
    public class LaptopModel
    {
        public int Id { get; set; }    
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string? Processor { get; set; }
        public string? LaptopImage { get; set; }
        [Required]
        public int CompanyID { get; set; }
        public CompanyModel CompanyModel { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetails> CartDetails { get; set; }
        [NotMapped]
        public string CompanyName {  get; set; }
    }
}
