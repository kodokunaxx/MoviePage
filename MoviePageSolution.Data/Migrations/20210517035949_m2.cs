using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePageSolution.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "Id", "Avatar", "DoB", "Fullname", "Gender", "Nationality" },
                values: new object[,]
                {
                    { 1, "https://image.tmdb.org/t/p/w500/lkW8gh20BuwzHecXqYH1eRVuWpb.jpg", new DateTime(1987, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lewis Tan", 1, "Manchester, England" },
                    { 2, "https://image.tmdb.org/t/p/w500/aAfaMEEqD8syHv5bLi5B3sccrM2.jpg", new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica McNamee", 2, "Sydney, Australia" },
                    { 3, "https://image.tmdb.org/t/p/w500/Am9vM77uZd9bGODugwmWtOfzx6E.jpg", new DateTime(1981, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh Lawson", 1, "Brisbane, Queensland, Australia" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hành động" },
                    { 2, "Viễn tưởng" },
                    { 3, "Kinh dị" },
                    { 4, "Phiêu lưu" },
                    { 5, "Tình cảm" },
                    { 6, "Hài hước" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Backdrop", "Director", "Episodes", "Language", "Nation", "Overview", "Poster", "Release_date", "Time", "Title", "Youtube" },
                values: new object[,]
                {
                    { 1, "https://localhost:44367/api/image/mortal-kombat-bg.jpg", "Simon McQuoid", 1, "Eng", "USA", "Mortal Kombat: Cuộc Chiến Sinh Tử xoay quanh võ sĩ võ thuật tổng hợp Cole Young (Lewis Tan), người mang trên mình một vết chàm rồng đen bí ẩn - biểu tượng của Mortal Kombat. Cole Young không hề biết về dòng máu bí ẩn đang chảy trong người anh, hay vì sao anh lại bị tên sát thủ Sub-Zero (Joe Taslim) săn lùng. Vì sự an nguy của gia đình, Cole cùng với một nhóm những chiến binh đã được tuyển chọn để tham gia vào một trận chiến đẫm máu nhằm chống lại những kẻ thù đến từ Outworld.", "https://localhost:44367/api/image/mortal-kombat-poster.jpg", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, "Mortal Kombat", "https://www.youtube.com/watch?v=-BQPKD7eozY" },
                    { 2, "https://localhost:44367/api/image/supergirl-banner.jpg", "Đỗ Mạnh Hà", 24, "Eng", "USA", "Supergirl là một phim truyền hình Mỹ được phát triển bởi Ali Adler, Greg Berlanti và Andrew Kreisberg ban đầu được phát sóng trên CBS và được công chiếu vào ngày 26 tháng 10 năm 2015", "https://localhost:44367/api/image/supergirl.jpg", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Super Girl", "https://www.youtube.com/watch?v=49RZx5tUKM4" },
                    { 3, "https://localhost:44367/api/image/wanda-banner.jpg", "Jac Schaeffer", 14, "Eng", "USA", "WandaVision là một miniseries truyền hình Mỹ do Jac Schaeffer tạo ra cho dịch vụ phát trực tuyến Disney +, dựa trên các nhân vật Marvel Comics Wanda Maximoff / Scarlet Witch và Vision.", "https://localhost:44367/api/image/wanda.png", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "WandaVision", "https://www.youtube.com/watch?v=sj9J2ecsSpo" }
                });

            migrationBuilder.InsertData(
                table: "MovieCast",
                columns: new[] { "Id", "Character", "IdCast", "IdMovie" },
                values: new object[,]
                {
                    { 3, "Kano", 3, 1 },
                    { 1, "Cole Young", 1, 1 },
                    { 2, "Sonya Blade", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "Id", "IdCategory", "IdMovie" },
                values: new object[,]
                {
                    { 9, 6, 3 },
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 1, 2 },
                    { 5, 3, 2 },
                    { 6, 5, 2 },
                    { 7, 3, 3 },
                    { 8, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DoB", "Email", "Fullname", "Gender", "Password", "PhoneNumber", "Position", "Username" },
                values: new object[] { 1, new DateTime(1999, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "haproadg@gmail.com", "Đỗ Mạnh Hà", 1, "1234", "123456789", 1, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cast",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCast",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieCast",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieCast",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieCategory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
