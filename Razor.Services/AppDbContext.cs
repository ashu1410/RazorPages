using Microsoft.EntityFrameworkCore;
using Razor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Razor.Services
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<resPage> resPages { get; set; }
    }
}
