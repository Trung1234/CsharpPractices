using GlobalManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalManager.Repositories
{
    public interface ICityRepository
    {
        Task<City> GetCityById(int id);
        Task<List<City>> GetCities();

    }
}
