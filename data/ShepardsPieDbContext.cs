using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShepardsPie.Models;

namespace ShephardsPies.Data;
public class ShephardsPiesDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Cheese> Cheeses { get; set; }
    public DbSet<PizzaSize> PizzaSizes { get; set; }
    public DbSet<Sauce> Sauces { get; set; }
    public DbSet<PizzaTopping> PizzaToppings { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Order> Orders { get; set; }
    public ShephardsPiesDbContext(DbContextOptions <ShephardsPiesDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[]
        {
            new(){
            Id = 1,
            FirstName = "Matthew",
            LastName = "Wilson",
            Address = "101 Main Street",
            Email = "skdbaksdb@gmail.com"
            },
            new(){
            Id = 2,
            FirstName = "Deanna",
            LastName = "Davis",
            Address = "103 Main Street",
            Email = "skdbaksdb@gmail.com"
            },
            new(){
            Id = 3,
            FirstName = "Caden",
            LastName = "Mildenhall",
            Address = "100 Main Street",
            Email = "skdbaksdb@gmail.com"
            },
            new(){
            Id = 4,
            FirstName = "Thomas",
            LastName = "Prince",
            Address = "108 Main Street",
            Email = "skdbaksdb@gmail.com"
            },
        });
        modelBuilder.Entity<Cheese>().HasData(new Cheese[]
        {
            new Cheese
            {
                Id =1,
                Name = "Buffalo Mozzarella"
            },
            new Cheese
            {
                Id =2,
                Name = "Four Cheese"
            },
            new Cheese
            {
                Id =3,
                Name = "Vegan"
            },
            new Cheese
            {
                Id =4,
                Name = "None"
            },
        });
        modelBuilder.Entity<PizzaSize>().HasData(new PizzaSize[]{
            new PizzaSize
            {
                Id = 1,
                Name="small (10\")",
                Cost = 10.00M
            },
            new PizzaSize
            {
                Id = 2,
                Name="medium (14\")",
                Cost = 12.00M
            },
            new PizzaSize
            {
                Id = 3,
                Name="large (18\")",
                Cost = 15.00M
            },
        });
         modelBuilder.Entity<Topping>().HasData(new Topping[]{
            new Topping
            {
                Id = 1,
                Name="sausage",
            },
            new Topping
            {
                Id = 2,
                Name="pepperoni",
            },
            new Topping
            {
                Id = 3,
                Name="mushroom",
            },
            new Topping
            {
                Id = 4,
                Name = "onion"
            },
            new Topping
            {
                Id = 5,
                Name = "green pepper"
            },
            new Topping
            {
                Id = 6,
                Name = "black olive"
            },
            new Topping
            {
                Id = 7,
                Name = "basil"
            },
            new Topping
            {
                Id = 8,
                Name = "extra cheese"
            },
        });
        modelBuilder.Entity<Sauce>().HasData(new Sauce[]{
            new Sauce
            {
                Id =1,
                Name = "Marinara"
            },
            new Sauce
            {
                Id =2,
                Name = "Arrabbiata"
            },
            new Sauce
            {
                Id =3,
                Name = "Garlic White"
            },
            new Sauce
            {
                Id =4,
                Name = "None"
            },
         });
        modelBuilder.Entity<Pizza>().HasData(new Pizza[]{
            new Pizza
            {
                Id = 1,
                CheeseId =1,
                SauceId =1,
                PizzaSizeId = 2,
                OrderId =1
            },
            new Pizza
            {
                Id = 2,
                CheeseId =4,
                SauceId =4,
                PizzaSizeId = 3,
                 OrderId =1
            },
            new Pizza
            {
                Id = 3,
                CheeseId =3,
                SauceId =2,
                PizzaSizeId = 1,
                 OrderId =1
            },
            new Pizza
            {
                Id = 4,
                CheeseId =2,
                SauceId =2,
                PizzaSizeId = 2,
                 OrderId =1
            },
            new Pizza
            {
                Id = 5,
                CheeseId =2,
                SauceId =3,
                PizzaSizeId = 3,
                 OrderId =2
            },
            new Pizza
            {
                Id = 6,
                CheeseId =3,
                SauceId =2,
                PizzaSizeId = 1,
                 OrderId =2
            },
            new Pizza
            {
                Id = 7,
                CheeseId =2,
                SauceId =1,
                PizzaSizeId = 2,
                 OrderId =2
            },
        });
        modelBuilder.Entity<PizzaTopping>().HasData(new PizzaTopping[]{
            new PizzaTopping
            {
                Id = 1,
                PizzaId = 2,
                ToppingId = 2,
            },
            new PizzaTopping
            {
                Id = 2,
                PizzaId = 2,
                ToppingId = 3,
            },
            new PizzaTopping
            {
                Id = 3,
                PizzaId = 3,
                ToppingId = 1,
            },
            new PizzaTopping
            {
                Id = 4,
                PizzaId = 2,
                ToppingId = 1,
            },
            new PizzaTopping
            {
                Id =5,
                PizzaId = 4,
                ToppingId = 1,
            },
            new PizzaTopping
            {
                Id = 6 ,
                PizzaId = 4,
                ToppingId = 3,
            },
            new PizzaTopping
            {
                Id = 7 ,
                PizzaId = 5,
                ToppingId = 1,
            },
            new PizzaTopping
            {
                Id = 8,
                PizzaId = 5,
                ToppingId = 3,
            },
            new PizzaTopping
            {
                Id = 9,
                PizzaId = 6,
                ToppingId = 3,
            },
            new PizzaTopping
            {
                Id = 10,
                PizzaId = 6,
                ToppingId = 2,
            },
            new PizzaTopping
            {
                Id = 11,
                PizzaId = 7,
                ToppingId = 1,
            },
            new PizzaTopping
            {
                Id = 12,
                PizzaId = 7,
                ToppingId = 3,
            },
            new PizzaTopping
            {
                Id = 13,
                PizzaId = 7,
                ToppingId = 2,
            },
            new PizzaTopping
            {
                Id = 14,
                PizzaId = 4,
                ToppingId = 1,
            },
        });
        modelBuilder.Entity<Order>().HasData(new Order[]{
            new Order
            {
                Id =1,
                TipAmount = 15.00M,
                UserProfileId = 1,
                TableId = 3,
                TimePlaced = new DateTime(2023,9,27)
            },
            new Order
            {
                Id = 2,
                TipAmount = 25.00M,
                UserProfileId = 1,
                DeliveryDriverId = 2,
                TimePlaced = new DateTime(2023,9,28)
            },
        });
    }
}