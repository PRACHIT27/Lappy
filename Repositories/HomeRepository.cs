

using Humanizer.Localisation;
using Lappy;
using Lappy.Data;
using Lappy.Models;
using Microsoft.EntityFrameworkCore;


namespace Lappy.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
       

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<CompanyModel>> Companies()
        {
            return await _db.Companies.ToListAsync();
        }
        public async Task<IEnumerable<LaptopModel>> GetLaptops(string sTerm = "", int companyId = 0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<LaptopModel> laptops = await (from laptop in _db.Laptops
                                                      join company in _db.Companies
                                                      on laptop.CompanyID equals company.Id
                                                      where string.IsNullOrWhiteSpace(sTerm) || (laptop != null && laptop.Name.ToLower().StartsWith(sTerm))
                                                      select new LaptopModel
                                                      {
                                                          Id = laptop.Id,
                                                          Name = laptop.Name,
                                                          Price = laptop.Price,
                                                          Ram = laptop.Ram,
                                                          Storage = laptop.Storage,
                                                          Processor = laptop.Processor,
                                                          LaptopImage = laptop.LaptopImage,
                                                          CompanyName = company.CompanyName,
                                                          CompanyID = company.Id
                                                      }
                         ).ToListAsync();
            if (companyId > 0)
            {
                foreach (var laptop in laptops)
                {
                    Console.WriteLine(laptop.CompanyID);
                }
                var filteredLaptops = laptops.Where(a => a.CompanyID == companyId).ToList();
                
                laptops = filteredLaptops;
            }
            return laptops;

        }
    }
}