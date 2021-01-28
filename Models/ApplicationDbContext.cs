using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Ebs.Models
{
    public class AppDbContext : DbContext
    {

        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false) { }
        }
        public DbSet<Categoria> Categorias { get; set; }

    }
}