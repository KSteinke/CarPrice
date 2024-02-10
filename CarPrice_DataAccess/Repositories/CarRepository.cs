using CarPrice_DataAccess.Repositories.Interfaces;
using CarPrice_Server.Data;
using Microsoft.EntityFrameworkCore;

namespace CarPrice_DataAccess.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarPriceDbContext _carPriceDbContext;
        public CarRepository(CarPriceDbContext carPriceDbContext)
        {
            _carPriceDbContext = carPriceDbContext;
        }

        public async Task<IEnumerable<string>> GetCarBrands()
        {
            IQueryable<string> query = _carPriceDbContext.Cars.Select(c => c.CarBrand).Distinct();
            IEnumerable<string> result = await query.ToListAsync();
            if(result != null)
            {
                return result;
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        public async Task<IEnumerable<string>> GetCarModels(string carBrand)
        {
            IQueryable<string> query = _carPriceDbContext.Cars.Where(c => c.CarBrand == carBrand).Select(c => c.Model).Distinct();
            IEnumerable<string> result = await query.ToListAsync();
            if(result != null)
            {
                return result;
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }
    }
}