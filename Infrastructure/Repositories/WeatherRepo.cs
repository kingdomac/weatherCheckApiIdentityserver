using Microsoft.EntityFrameworkCore;
using WeatherCheckApi.Domain.Entities;
using WeatherCheckApi.Domain.Interfaces;

namespace WeatherCheckApi.Infrastructure.Repositories
{
    public class WeatherRepo : IWeatherRepo
    {
        private readonly ApplicationDbContext _dataContext;

        public WeatherRepo(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> CreateHistoryAsync(Weather weather)
        {
            _dataContext.Weathers.Add(weather);
            return await saveAsync();
        }

        public async Task<ICollection<Weather>> GetHistoryOfCityAsync(string city, string userId)
        {
            return await _dataContext.Weathers
                .Where(w => w.CityName.Trim().ToLower().Contains(city.Trim().ToLower()) && w.User.Id == userId)
                .OrderByDescending(w => w.RequestDateTime)
                .ToListAsync();
        }

        public async Task<bool> saveAsync()
        {
            var saved = await _dataContext.SaveChangesAsync();
            return saved > 0;
        }
    }
}
