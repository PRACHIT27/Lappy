namespace Lappy.Models.DTO
{
    public class LaptopDisplayModel
    {
        public IEnumerable<LaptopModel> Laptops { get; set; }
        public IEnumerable<CompanyModel> Companies{ get; set; }
        public string STerm { get; set; } = "";
        public int CompanyId { get; set; } = 0;
    }
}
