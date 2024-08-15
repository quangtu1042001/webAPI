namespace webapi.MyModels.Configure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DonHangConfiguration : IEntityTypeConfiguration<DonHang>
{
    public void Configure(EntityTypeBuilder<DonHang> builder)
    {
        builder.ToTable("tblDonHang");

        builder.HasKey(dh => dh.Id);

        builder.Property(dh => dh.NgayDatHang)
            .IsRequired();

        builder.HasOne(dh => dh.Khachhang)
            .WithMany(kh => kh.DonHangs)
            .HasForeignKey(dh => dh.KhachhangId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
