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
                    { 1, "image.tmdb.org/t/p/w500/lkW8gh20BuwzHecXqYH1eRVuWpb.jpg", new DateTime(1987, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lewis Tan", 1, "Manchester, England" },
                    { 2, "image.tmdb.org/t/p/w500/aAfaMEEqD8syHv5bLi5B3sccrM2.jpg", new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica McNamee", 2, "Sydney, Australia" },
                    { 3, "image.tmdb.org/t/p/w500/Am9vM77uZd9bGODugwmWtOfzx6E.jpg", new DateTime(1981, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh Lawson", 1, "Brisbane, Queensland, Australia" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hành động" },
                    { 2, "Viễn tưởng" },
                    { 3, "Kinh dị" },
                    { 4, "Tình cảm" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Backdrop", "Director", "Episodes", "Language", "Nation", "Overview", "Poster", "Release_date", "Time", "Title", "Youtube" },
                values: new object[] { 1, "image.tmdb.org/t/p/w500/9yBVqNruk6Ykrwc32qrK2TIE5xw.jpg", "Simon McQuoid", 1, "Eng", "USA", "Mortal Kombat: Cuộc Chiến Sinh Tử xoay quanh võ sĩ võ thuật tổng hợp Cole Young (Lewis Tan), người mang trên mình một vết chàm rồng đen bí ẩn - biểu tượng của Mortal Kombat. Cole Young không hề biết về dòng máu bí ẩn đang chảy trong người anh, hay vì sao anh lại bị tên sát thủ Sub-Zero (Joe Taslim) săn lùng. Vì sự an nguy của gia đình, Cole cùng với một nhóm những chiến binh đã được tuyển chọn để tham gia vào một trận chiến đẫm máu nhằm chống lại những kẻ thù đến từ Outworld.", "image.tmdb.org/t/p/w500/5iHZ6KUSnLEnStXJ6BfFA5Uk2PT.jpg", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, "Mortal Kombat", "youtube.com/watch?v=-BQPKD7eozY" });

            migrationBuilder.InsertData(
                table: "MovieCast",
                columns: new[] { "Id", "Character", "IdCast", "IdMovie" },
                values: new object[,]
                {
                    { 1, "Cole Young", 1, 1 },
                    { 2, "Sonya Blade", 2, 1 },
                    { 3, "Kano", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategory",
                columns: new[] { "Id", "IdCategory", "IdMovie" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 }
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
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
