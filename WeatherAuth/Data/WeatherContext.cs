using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherAuth.Models;

namespace WeatherAuth.Data
{
    public class WeatherContext : IdentityDbContext<AppUser>
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {

        }
    }
}
