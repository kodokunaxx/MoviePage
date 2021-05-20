﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviePageSolution.Data.EF;

namespace MoviePageSolution.Data.Migrations
{
    [DbContext(typeof(MoviePageDbContext))]
    [Migration("20210518065448_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cast");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "https://image.tmdb.org/t/p/w500/lkW8gh20BuwzHecXqYH1eRVuWpb.jpg",
                            DoB = new DateTime(1987, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fullname = "Lewis Tan",
                            Gender = 1,
                            Nationality = "Manchester, England"
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "https://image.tmdb.org/t/p/w500/aAfaMEEqD8syHv5bLi5B3sccrM2.jpg",
                            DoB = new DateTime(1986, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fullname = "Jessica McNamee",
                            Gender = 2,
                            Nationality = "Sydney, Australia"
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "https://image.tmdb.org/t/p/w500/Am9vM77uZd9bGODugwmWtOfzx6E.jpg",
                            DoB = new DateTime(1981, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fullname = "Josh Lawson",
                            Gender = 1,
                            Nationality = "Brisbane, Queensland, Australia"
                        });
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hành động"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Viễn tưởng"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kinh dị"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Phiêu lưu"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tình cảm"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hài hước"
                        });
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdUser")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Backdrop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Backdrop = "https://localhost:44367/api/image/mortal-kombat-bg.jpg",
                            Director = "Simon McQuoid",
                            Episodes = 1,
                            Language = "Eng",
                            Nation = "USA",
                            Overview = "Mortal Kombat: Cuộc Chiến Sinh Tử xoay quanh võ sĩ võ thuật tổng hợp Cole Young (Lewis Tan), người mang trên mình một vết chàm rồng đen bí ẩn - biểu tượng của Mortal Kombat. Cole Young không hề biết về dòng máu bí ẩn đang chảy trong người anh, hay vì sao anh lại bị tên sát thủ Sub-Zero (Joe Taslim) săn lùng. Vì sự an nguy của gia đình, Cole cùng với một nhóm những chiến binh đã được tuyển chọn để tham gia vào một trận chiến đẫm máu nhằm chống lại những kẻ thù đến từ Outworld.",
                            Poster = "https://localhost:44367/api/image/mortal-kombat-poster.jpg",
                            Release_date = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Time = 110,
                            Title = "Mortal Kombat",
                            Youtube = "https://www.youtube.com/watch?v=-BQPKD7eozY"
                        },
                        new
                        {
                            Id = 2,
                            Backdrop = "https://localhost:44367/api/image/supergirl-banner.jpg",
                            Director = "Đỗ Mạnh Hà",
                            Episodes = 24,
                            Language = "Eng",
                            Nation = "USA",
                            Overview = "Supergirl là một phim truyền hình Mỹ được phát triển bởi Ali Adler, Greg Berlanti và Andrew Kreisberg ban đầu được phát sóng trên CBS và được công chiếu vào ngày 26 tháng 10 năm 2015",
                            Poster = "https://localhost:44367/api/image/supergirl.jpg",
                            Release_date = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Time = 45,
                            Title = "Super Girl",
                            Youtube = "https://www.youtube.com/watch?v=49RZx5tUKM4"
                        },
                        new
                        {
                            Id = 3,
                            Backdrop = "https://localhost:44367/api/image/wanda-banner.jpg",
                            Director = "Jac Schaeffer",
                            Episodes = 14,
                            Language = "Eng",
                            Nation = "USA",
                            Overview = "WandaVision là một miniseries truyền hình Mỹ do Jac Schaeffer tạo ra cho dịch vụ phát trực tuyến Disney +, dựa trên các nhân vật Marvel Comics Wanda Maximoff / Scarlet Witch và Vision.",
                            Poster = "https://localhost:44367/api/image/wanda.png",
                            Release_date = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Time = 23,
                            Title = "WandaVision",
                            Youtube = "https://www.youtube.com/watch?v=sj9J2ecsSpo"
                        });
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.MovieCast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdCast")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdMovie")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MovieCast");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Character = "Cole Young",
                            IdCast = 1,
                            IdMovie = 1
                        },
                        new
                        {
                            Id = 2,
                            Character = "Sonya Blade",
                            IdCast = 2,
                            IdMovie = 1
                        },
                        new
                        {
                            Id = 3,
                            Character = "Kano",
                            IdCast = 3,
                            IdMovie = 1
                        });
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.MovieCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdCategory")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdMovie")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MovieCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdCategory = 1,
                            IdMovie = 1
                        },
                        new
                        {
                            Id = 2,
                            IdCategory = 2,
                            IdMovie = 1
                        },
                        new
                        {
                            Id = 3,
                            IdCategory = 3,
                            IdMovie = 1
                        },
                        new
                        {
                            Id = 4,
                            IdCategory = 1,
                            IdMovie = 2
                        },
                        new
                        {
                            Id = 5,
                            IdCategory = 3,
                            IdMovie = 2
                        },
                        new
                        {
                            Id = 6,
                            IdCategory = 5,
                            IdMovie = 2
                        },
                        new
                        {
                            Id = 7,
                            IdCategory = 3,
                            IdMovie = 3
                        },
                        new
                        {
                            Id = 8,
                            IdCategory = 5,
                            IdMovie = 3
                        },
                        new
                        {
                            Id = 9,
                            IdCategory = 6,
                            IdMovie = 3
                        });
                });

            modelBuilder.Entity("MoviePageSolution.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DoB = new DateTime(1999, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "haproadg@gmail.com",
                            Fullname = "Đỗ Mạnh Hà",
                            Gender = 1,
                            Password = "1234",
                            PhoneNumber = "123456789",
                            Position = 1,
                            Username = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
