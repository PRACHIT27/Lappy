using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lappy.Models
{
    [Table("Companies")]
    public class CompanyModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }
        public List<LaptopModel> Laptops { get; set; }
    }
}
