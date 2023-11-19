using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherCheckApi.Domain.Entities
{
    public class Weather
    {
        public int Id { get; set; }
        public required string CityName { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public float WindSpeedKm { get; set; }

        public int Humidity { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public float TemperatureC { get; set; }

        public DateTime RequestDateTime { get; set; }

        public DateTime CreatedAt;

        public required string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
