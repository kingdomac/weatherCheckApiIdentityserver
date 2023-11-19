
namespace WeatherCheckApi.Domain.Interfaces
{
    public interface IWeatherApiProvider
    {
        public Task<HttpResponseMessage> GetWeatherByCity(string city);
    }
}
