using CarPrice_DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPrice_Server.Data;
    public class CarPriceDbContext:DbContext
    {
        public CarPriceDbContext(DbContextOptions<CarPriceDbContext> options):base(options) 
        {

        }

        public DbSet<Record> Records {get; set;}
        public DbSet<Car> Cars {get; set;}
        public DbSet<Engine> Engines {get; set;}
        
    }