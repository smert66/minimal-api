namespace PizzaStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using PizzaStore.Models;

    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, Name = "Pepperoni", Description = "Classic Pepperoni Pizza"});
        }
    }
}