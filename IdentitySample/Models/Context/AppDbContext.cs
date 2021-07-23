using Microsoft.AspNetCore.Identity.EntityFrameworkCore; //Add => IdentityDbContext 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Models.Context
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Employees> Employees { get; set; }
    }
}
