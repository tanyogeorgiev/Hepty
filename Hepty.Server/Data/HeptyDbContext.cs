namespace Hepty.Data
{
    using Hepty.Data.Migrations.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class HeptyDbContext : IdentityDbContext<User>
    {
        public HeptyDbContext(DbContextOptions<HeptyDbContext> options)
            : base(options)
        {
        }
    }
}
