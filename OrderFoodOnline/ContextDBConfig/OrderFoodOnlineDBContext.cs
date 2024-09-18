using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderFoodOnline.Models;
using System;

namespace OrderFoodOnline.ContextDBConfig
{
  public class OrderFoodOnlineDBContext : IdentityDbContext<ApplicationUser>
  {
    //public OrderFoodOnlineDBContext() { }
    public OrderFoodOnlineDBContext(DbContextOptions<OrderFoodOnlineDBContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }

    public DbSet<Order> Orders { get; set; }
  }
}
