using Microsoft.EntityFrameworkCore;
using ProductsAPI.Domains;

namespace ProductsAPI.Context
{
    public class ProductsAPIContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MHF127S; initial catalog=ProductsApi_GuiLuiz_tarde; user Id= sa; pwd=Senai@134; TrustServerCertificate=true;");
    }
}