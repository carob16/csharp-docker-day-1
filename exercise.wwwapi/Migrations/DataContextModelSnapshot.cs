﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.wwwapi.Data;

#nullable disable

namespace exercise.wwwapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("exercise.wwwapi.DataModels.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentCount")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            StudentCount = 0,
                            Title = "Not Specified"
                        },
                        new
                        {
                            Id = 1,
                            StudentCount = 0,
                            Title = "C#"
                        },
                        new
                        {
                            Id = 2,
                            StudentCount = 0,
                            Title = "Java"
                        },
                        new
                        {
                            Id = 3,
                            StudentCount = 0,
                            Title = "C"
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("AverageGrade")
                        .HasColumnType("double precision")
                        .HasColumnName("average_grade");

                    b.Property<DateTime>("CourseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("course_date");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer")
                        .HasColumnName("course_id");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageGrade = 4.6399999999999997,
                            CourseDate = new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1980, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Middleton"
                        },
                        new
                        {
                            Id = 2,
                            AverageGrade = 2.1899999999999999,
                            CourseDate = new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1997, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Charles",
                            LastName = "Hendrix"
                        },
                        new
                        {
                            Id = 3,
                            AverageGrade = 8.9299999999999997,
                            CourseDate = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1981, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Jagger"
                        },
                        new
                        {
                            Id = 4,
                            AverageGrade = 3.8100000000000001,
                            CourseDate = new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1973, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Barack",
                            LastName = "Jagger"
                        },
                        new
                        {
                            Id = 5,
                            AverageGrade = 3.6600000000000001,
                            CourseDate = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1977, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Obama"
                        },
                        new
                        {
                            Id = 6,
                            AverageGrade = 1.77,
                            CourseDate = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1995, 8, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Emma",
                            LastName = "Hendrix"
                        },
                        new
                        {
                            Id = 7,
                            AverageGrade = 7.6399999999999997,
                            CourseDate = new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1988, 8, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mick",
                            LastName = "Jagger"
                        },
                        new
                        {
                            Id = 8,
                            AverageGrade = 5.9800000000000004,
                            CourseDate = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1980, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Charles",
                            LastName = "Jacobsen"
                        },
                        new
                        {
                            Id = 9,
                            AverageGrade = 5.9500000000000002,
                            CourseDate = new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1993, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Arthur",
                            LastName = "Olsen"
                        },
                        new
                        {
                            Id = 10,
                            AverageGrade = 6.9800000000000004,
                            CourseDate = new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1972, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mick",
                            LastName = "Olsen"
                        },
                        new
                        {
                            Id = 11,
                            AverageGrade = 8.9700000000000006,
                            CourseDate = new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1975, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Oprah",
                            LastName = "Jacobsen"
                        },
                        new
                        {
                            Id = 12,
                            AverageGrade = 9.7799999999999994,
                            CourseDate = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1994, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Middleton"
                        },
                        new
                        {
                            Id = 13,
                            AverageGrade = 9.4600000000000009,
                            CourseDate = new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1996, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Oprah",
                            LastName = "Olsen"
                        },
                        new
                        {
                            Id = 14,
                            AverageGrade = 0.23999999999999999,
                            CourseDate = new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1976, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Trump"
                        },
                        new
                        {
                            Id = 15,
                            AverageGrade = 5.2699999999999996,
                            CourseDate = new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(2004, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Donald",
                            LastName = "Hepburn"
                        },
                        new
                        {
                            Id = 16,
                            AverageGrade = 8.8000000000000007,
                            CourseDate = new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1991, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mick",
                            LastName = "Obama"
                        },
                        new
                        {
                            Id = 17,
                            AverageGrade = 7.1900000000000004,
                            CourseDate = new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1989, 7, 5, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Emma",
                            LastName = "Presley"
                        },
                        new
                        {
                            Id = 18,
                            AverageGrade = 6.3600000000000003,
                            CourseDate = new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1971, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Elvis",
                            LastName = "Winfrey"
                        },
                        new
                        {
                            Id = 19,
                            AverageGrade = 2.6699999999999999,
                            CourseDate = new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1996, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mick",
                            LastName = "Winslet"
                        },
                        new
                        {
                            Id = 20,
                            AverageGrade = 2.6299999999999999,
                            CourseDate = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1982, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Donald",
                            LastName = "Hepburn"
                        },
                        new
                        {
                            Id = 21,
                            AverageGrade = 1.5800000000000001,
                            CourseDate = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(2005, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Jimi",
                            LastName = "Winfrey"
                        },
                        new
                        {
                            Id = 22,
                            AverageGrade = 0.059999999999999998,
                            CourseDate = new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(2007, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Charles",
                            LastName = "Olsen"
                        },
                        new
                        {
                            Id = 23,
                            AverageGrade = 8.8499999999999996,
                            CourseDate = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1987, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Mick",
                            LastName = "Middleton"
                        },
                        new
                        {
                            Id = 24,
                            AverageGrade = 5.1399999999999997,
                            CourseDate = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1975, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Charles",
                            LastName = "Windsor"
                        },
                        new
                        {
                            Id = 25,
                            AverageGrade = 5.0599999999999996,
                            CourseDate = new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(1970, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Winslet"
                        },
                        new
                        {
                            Id = 26,
                            AverageGrade = 2.96,
                            CourseDate = new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 3,
                            DateOfBirth = new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Jimi",
                            LastName = "Trump"
                        },
                        new
                        {
                            Id = 27,
                            AverageGrade = 5.5099999999999998,
                            CourseDate = new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 1,
                            DateOfBirth = new DateTime(1978, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Oprah",
                            LastName = "Trump"
                        },
                        new
                        {
                            Id = 28,
                            AverageGrade = 2.7000000000000002,
                            CourseDate = new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(1996, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Emma",
                            LastName = "Hepburn"
                        },
                        new
                        {
                            Id = 29,
                            AverageGrade = 1.3600000000000001,
                            CourseDate = new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            CourseId = 2,
                            DateOfBirth = new DateTime(2005, 6, 13, 0, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Kate",
                            LastName = "Obama"
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Student", b =>
                {
                    b.HasOne("exercise.wwwapi.DataModels.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Course", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
