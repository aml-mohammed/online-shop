using AmlShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.datacontext
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
                
        }
        public DbSet<Product> product { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<CartStatus> cartStatus { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Member> member { get; set; }
        public DbSet<MemberRole> memberRole { get; set; }
        public DbSet<Roles> role { get; set; }
        public DbSet<ShippingDetails> shippingDetails { get; set; }
        public DbSet<SlideImage> slideImage { get; set; }
    }
}
