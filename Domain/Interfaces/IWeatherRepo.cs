using System.Threading.Tasks;
using WeatherCheckApi.Domain.Entities;

namespace WeatherCheckApi.Domain.Interfaces
{
    public interface IWeatherRepo
    {
        Task<ICollection<Weather>> GetHistoryOfCityAsync(string city, string userId);
        Task<bool> CreateHistoryAsync(Weather weather);
        Task<bool> saveAsync();
    }
}
