using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using Microsoft.Extensions.Options;

namespace WebAPI.Context
{
    public class ApiContext : DbContext
    {
        public DbSet<WeatherForecast> weatherForecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=forecast.db");
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
