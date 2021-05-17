using System;
using FlyUpCore5.Models;
using Microsoft.EntityFrameworkCore;


namespace FlyUpCore5.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        //public DbSet<Video> Videos { get; set; }
        public DbSet<Video> Video { get; set; }

        //public DbSet<Activity> Activities { get; set; }
        public DbSet<Activity> Activity { get; set; }


    }
}
