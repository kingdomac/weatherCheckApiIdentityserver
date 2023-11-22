using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data
{
    public class IdentityServerDbContext : IdentityDbContext<IdentityUser>
    {
        public IdentityServerDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
