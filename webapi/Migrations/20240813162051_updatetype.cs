using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class updatetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
            name: "NgayDatHang",
            table: "tblDonHang",
            type: "datetime", // Chỉ định kiểu dữ liệu là datetime
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "datetime2"); // Kiểu dữ liệu cũ
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
            name: "NgayDatHang",
            table: "tblDonHang",
            type: "datetime2", // Khôi phục kiểu dữ liệu cũ nếu cần
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "datetime"); // Kiểu dữ liệu mới
        }
    }
}
