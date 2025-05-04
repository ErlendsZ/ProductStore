using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductStore.Models;

namespace ProductStore.Data
{
    /// <summary>
    /// Application's database context, inheriting from IdentityDbContext.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// Configures the context with the provided options for database access.
        /// </summary>
        /// <param name="options">Db context options.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Table in databese contains product info.
        /// </summary>
        public DbSet<Product> Products { get; set; }
    }
}
