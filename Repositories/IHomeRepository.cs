
using Lappy.Models;

namespace Lappy
{
    public interface IHomeRepository
    {
        Task<IEnumerable<CompanyModel>> Companies();
        Task<IEnumerable<LaptopModel>> GetLaptops(string sTerm = "", int genreId = 0);
 
    }
}