using Microsoft.EntityFrameworkCore;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region User
            modelBuilder.Entity<User>().HasData(
                new User() {
                    Id = 1,
                    Username = "admin",
                    Password = "1234",
                    Fullname = "Đỗ Mạnh Hà",
                    Gender = 1,
                    Email = "haproadg@gmail.com",
                    DoB = new DateTime(1999,12,14),
                    PhoneNumber = "123456789",
                    Position = 1
                }
            );
            #endregion

            #region Cast
            modelBuilder.Entity<Cast>().HasData(
                new Cast()
                {
                    Id = 1,
                    Fullname = "Lewis Tan",
                    DoB = new DateTime(1987,02,04),
                    Gender = 1,
                    Nationality = "Manchester, England",
                    Avatar = "image.tmdb.org/t/p/w500/lkW8gh20BuwzHecXqYH1eRVuWpb.jpg"
                },
                new Cast()
                {
                    Id = 2,
                    Fullname = "Jessica McNamee",
                    DoB = new DateTime(1986,02,21),
                    Gender = 2,
                    Nationality = "Sydney, Australia",
                    Avatar = "image.tmdb.org/t/p/w500/aAfaMEEqD8syHv5bLi5B3sccrM2.jpg"
                },
                new Cast()
                {
                    Id = 3,
                    Fullname = "Josh Lawson",
                    DoB = new DateTime(1981,07,22),
                    Gender = 1,
                    Nationality = "Brisbane, Queensland, Australia",
                    Avatar = "image.tmdb.org/t/p/w500/Am9vM77uZd9bGODugwmWtOfzx6E.jpg"
                }
            );
            #endregion

            #region Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 1,
                    Title = "Mortal Kombat",
                    Overview = "Mortal Kombat: Cuộc Chiến Sinh Tử xoay quanh võ sĩ võ thuật tổng hợp Cole Young (Lewis Tan), người mang trên mình một vết chàm rồng đen bí ẩn - biểu tượng của Mortal Kombat. Cole Young không hề biết về dòng máu bí ẩn đang chảy trong người anh, hay vì sao anh lại bị tên sát thủ Sub-Zero (Joe Taslim) săn lùng. Vì sự an nguy của gia đình, Cole cùng với một nhóm những chiến binh đã được tuyển chọn để tham gia vào một trận chiến đẫm máu nhằm chống lại những kẻ thù đến từ Outworld.",
                    Release_date = new DateTime(2021,04,07),
                    Director = "Simon McQuoid",
                    Backdrop = "image.tmdb.org/t/p/w500/9yBVqNruk6Ykrwc32qrK2TIE5xw.jpg",
                    Poster = "image.tmdb.org/t/p/w500/5iHZ6KUSnLEnStXJ6BfFA5Uk2PT.jpg",
                    Time = 110,
                    Nation = "USA",
                    Episodes = 1,
                    Language = "Eng",
                    Youtube = "youtube.com/watch?v=-BQPKD7eozY"
                }
            );
            #endregion

            #region Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Hành động"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Viễn tưởng"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Kinh dị"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Tình cảm"
                }
            );
            #endregion

            #region MovieCast
            modelBuilder.Entity<MovieCast>().HasData(
                new MovieCast()
                {
                    Id = 1,
                    IdMovie = 1,
                    IdCast = 1,
                    Character = "Cole Young"
                },
                new MovieCast()
                {
                    Id = 2,
                    IdMovie = 1,
                    IdCast = 2,
                    Character = "Sonya Blade"
                },
                new MovieCast()
                {
                    Id = 3,
                    IdMovie = 1,
                    IdCast = 3,
                    Character = "Kano"
                }
            );
            #endregion

            #region MovieCategory
            modelBuilder.Entity<MovieCategory>().HasData(
                new MovieCategory()
                {
                    Id = 1,
                    IdCategory = 1,
                    IdMovie = 1
                },
                new MovieCategory()
                {
                    Id = 2,
                    IdCategory = 2,
                    IdMovie = 1
                },
                new MovieCategory()
                {
                    Id = 3,
                    IdCategory = 3,
                    IdMovie = 1
                }
            );
            #endregion
        }
    }
}
