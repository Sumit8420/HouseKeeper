using HouseKeppingApi.Models; //*
using Microsoft.EntityFrameworkCore;

namespace HouseKeppingApi.Data
{
    public class HouseDbContext : DbContext
    {
        public HouseDbContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet

        public DbSet<HouseKeeping> Housekeepings { get; set; }


    }
}
