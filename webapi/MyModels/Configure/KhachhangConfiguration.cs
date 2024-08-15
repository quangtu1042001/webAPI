namespace webapi.MyModels.Configure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class KhachhangConfiguration : IEntityTypeConfiguration<Khachhang>
{
    public void Configure(EntityTypeBuilder<Khachhang> builder)
    {
        builder.ToTable("tblKhachhang");

        builder.HasKey(kh => kh.Id);

        builder.Property(kh => kh.Ma)
            .HasMaxLength(10);

        builder.Property(kh => kh.Ten)
            .HasMaxLength(200);

        builder.Property(kh => kh.Diachi)
            .HasMaxLength(200);

        builder.Property(kh => kh.Tel)
            .HasMaxLength(100);

        builder.Property(kh => kh.Email)
            .HasMaxLength(100);
    }
}
