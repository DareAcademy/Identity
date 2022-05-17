using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IdentitySession2102.data
{
    public class HRContext:IdentityDbContext<ApplicationUser>
    {
        IConfiguration config;
        public HRContext(IConfiguration _config)
        {
            config = _config;
        }
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("HRConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
