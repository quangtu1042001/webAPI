using Microsoft.EntityFrameworkCore;
using webapi.MyModels.Configure;

namespace webapi.MyModels
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new KhachhangConfiguration());
            modelBuilder.ApplyConfiguration(new DonHangConfiguration());
        }
    }
}
