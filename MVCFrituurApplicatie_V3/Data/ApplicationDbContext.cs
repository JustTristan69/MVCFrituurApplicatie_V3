using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCFrituurApplicatie_V3.Models;

namespace MVCFrituurApplicatie_V3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCFrituurApplicatie_V3.Models.Item> Item { get; set; } = default!;
        public DbSet<MVCFrituurApplicatie_V3.Models.Orderregel> Orderregel { get; set; } = default!;
        public DbSet<MVCFrituurApplicatie_V3.Models.Order> Order { get; set; } = default!;
    }
}