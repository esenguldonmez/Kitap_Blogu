using Bitirme_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitirme_Proje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ZEYNEP\\SQLEXPRESS;database=BitirmeProjeDB2;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
