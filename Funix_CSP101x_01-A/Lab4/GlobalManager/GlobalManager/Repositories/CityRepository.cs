using GlobalManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace GlobalManager.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly worldContext _context;

        public CityRepository(worldContext context)
        {
            _context = context;
        }
        public Task<List<City>> GetCities()
        {
            var worldContext = _context.City.Include(c => c.CountryCodeNavigation);
            return worldContext.ToListAsync();
        }

        public Task<City> GetCityById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
