using ECommerce.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Persistence
{
    public class EcommerceDbContext : DbContext 
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products{ get; set; }
    }
}
