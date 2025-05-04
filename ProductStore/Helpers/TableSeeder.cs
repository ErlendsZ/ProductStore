using Microsoft.EntityFrameworkCore;
using ProductStore.Data;
using ProductStore.Models;

namespace ProductStore.Helpers
{
    /// <summary>
    /// Seeder used for table creation.
    /// <summary>
    public class TableSeeder
    {
        /// <summary>
        /// Creates and seeds data for Product table if it don't already exist.
        /// </summary>
        public static async Task SeedProductTableAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

                var products = new Product[]
                {
                    new Product { Title = "HDD 1TB", Quantity = 10, Price = 50 },
                    new Product { Title = "HDD SSD 512GB", Quantity = 5, Price = 30.99M },
                    new Product { Title = "RAM DDR4 16GB", Quantity = 20, Price = 10.12M }
                };

                foreach (var product in products)
                {

                    await context.Products.AddAsync(product);
                }
            }
        }
    }
