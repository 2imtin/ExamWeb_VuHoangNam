using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_VuHoangNam.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Phims",
               columns: new[] { "Id", "TuaDe", "DienVien", "TrongNuoc", "GiaVe","ThoiLuong" },
               values: new object[,]
               {
                    { 1, "Chúng ta của 8 năm sau", "Huyền Lizzie, Mạnh Trường", true, 150000,110 },
                    { 2, "Avatar", "Sam Worthington", false, 250000,161 },
                    { 3, "Gặp em ngày nắng", "Đình Tú, Anh Đào", true, 160000,105 },
                    { 4, "Không ngại cưới", "Hoàng Thùy Linh, Nhan Phúc Vinh", true, 120000,150 },
                    { 5, "Gia đình đại chiến", "Đức Khuê, Nguyệt Hằng", true, 130000,120 },
                    { 6, "Kẻ Huỷ Diệt", "Arnold Schwarzenegger", false, 210000,107 }
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Phims",
               keyColumn: "Id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
