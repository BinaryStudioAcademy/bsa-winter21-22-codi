﻿// <auto-generated />
using System;
using Codi.Core.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Codi.Core.DAL.Migrations
{
    [DbContext(typeof(CodiCoreContext))]
    [Migration("20220209060047_AddUnitCourseRelation")]
    partial class AddUnitCourseRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Codi.Core.DAL.Entities.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("AvatarId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.CourseRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseRoles");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.CourseUser", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<long>("CourseRoleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseRoleId");

                    b.ToTable("CourseUsers");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.InvitedUser", b =>
                {
                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("InvitedUsers");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Lesson", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UnitId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UnitId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Sample", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Samples");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            Body = "Eligendi quisquam ullam iure praesentium numquam sapiente distinctio ad. Tempore voluptatibus ad et adipisci hic amet. Corporis soluta cupiditate soluta. Provident rerum nemo dolores debitis dicta voluptatem labore dolores adipisci. Adipisci illo quidem sit dolores. Ea dolor animi quod laborum quia perspiciatis sunt tempora.",
                            CreatedAt = new DateTime(2020, 7, 1, 1, 14, 20, 556, DateTimeKind.Unspecified).AddTicks(7372),
                            CreatedBy = 5L,
                            IsDeleted = false,
                            Title = "hic"
                        },
                        new
                        {
                            Id = 3L,
                            Body = "Incidunt perferendis omnis. Quas voluptatem beatae vitae sunt a ut sed repellendus. Accusamus eos enim consequatur et praesentium ad ut beatae eius. Omnis voluptas error et velit autem ipsa atque consequuntur vitae. Nostrum accusamus soluta nisi.",
                            CreatedAt = new DateTime(2020, 11, 26, 1, 10, 54, 982, DateTimeKind.Unspecified).AddTicks(9175),
                            CreatedBy = 4L,
                            IsDeleted = false,
                            Title = "velit"
                        },
                        new
                        {
                            Id = 4L,
                            Body = "Architecto laboriosam culpa cumque dicta in. Perspiciatis amet autem rerum recusandae perspiciatis pariatur. Eum sint molestiae quis neque tempora ab distinctio. Nobis nulla dignissimos voluptas nemo cumque tenetur quod et placeat. Nihil sit eos similique fuga enim dolores ullam suscipit.",
                            CreatedAt = new DateTime(2021, 1, 18, 12, 14, 38, 642, DateTimeKind.Unspecified).AddTicks(7703),
                            CreatedBy = 1L,
                            IsDeleted = false,
                            Title = "est"
                        },
                        new
                        {
                            Id = 5L,
                            Body = "Sapiente et saepe ut atque dolore accusantium soluta cumque perferendis. Magni adipisci labore corrupti. Ratione et quibusdam consequatur voluptatem velit expedita eos maxime.",
                            CreatedAt = new DateTime(2020, 2, 2, 15, 3, 56, 551, DateTimeKind.Unspecified).AddTicks(1864),
                            CreatedBy = 5L,
                            IsDeleted = false,
                            Title = "placeat"
                        },
                        new
                        {
                            Id = 6L,
                            Body = "Iusto aspernatur nihil iure ut blanditiis veritatis quas. Et illum quod atque nulla voluptas quos beatae quaerat consequatur. Ab placeat tenetur perferendis et omnis. Doloremque corrupti deserunt sint enim ex sit.",
                            CreatedAt = new DateTime(2021, 4, 7, 16, 50, 6, 239, DateTimeKind.Unspecified).AddTicks(5929),
                            CreatedBy = 3L,
                            IsDeleted = false,
                            Title = "facere"
                        },
                        new
                        {
                            Id = 7L,
                            Body = "Doloremque omnis facilis unde exercitationem consectetur culpa porro consequatur sed. Vel rem rerum eum harum. Ratione voluptate est officia accusamus doloremque perferendis ea. Unde iure laudantium ut amet repellendus enim consequatur dolor porro. Sed expedita dolorem aperiam ipsa omnis. Ut omnis ipsa quia cupiditate iure.",
                            CreatedAt = new DateTime(2019, 7, 23, 7, 33, 40, 245, DateTimeKind.Unspecified).AddTicks(9313),
                            CreatedBy = 5L,
                            IsDeleted = false,
                            Title = "impedit"
                        },
                        new
                        {
                            Id = 8L,
                            Body = "Nesciunt placeat et consectetur enim. Consectetur magnam perspiciatis ut rem perspiciatis odit dolorem. Modi corrupti corrupti.",
                            CreatedAt = new DateTime(2020, 1, 27, 9, 1, 30, 801, DateTimeKind.Unspecified).AddTicks(8159),
                            CreatedBy = 3L,
                            IsDeleted = false,
                            Title = "corporis"
                        },
                        new
                        {
                            Id = 9L,
                            Body = "Omnis culpa earum modi eos beatae autem. Deleniti labore veritatis dolorum. Omnis perferendis ut sit nulla autem ut voluptatem voluptas ut.",
                            CreatedAt = new DateTime(2021, 3, 25, 21, 11, 5, 602, DateTimeKind.Unspecified).AddTicks(6614),
                            CreatedBy = 5L,
                            IsDeleted = false,
                            Title = "perspiciatis"
                        },
                        new
                        {
                            Id = 10L,
                            Body = "Molestias porro exercitationem omnis et eius. Est consequatur esse sit quia dolorem sequi doloribus corporis. Perspiciatis qui dignissimos.",
                            CreatedAt = new DateTime(2021, 4, 7, 22, 46, 32, 439, DateTimeKind.Unspecified).AddTicks(5958),
                            CreatedBy = 3L,
                            IsDeleted = false,
                            Title = "esse"
                        },
                        new
                        {
                            Id = 11L,
                            Body = "Eos eum perferendis nisi alias et ducimus repudiandae ut. Voluptas rerum ullam omnis placeat non ea voluptatibus. Sint et et asperiores omnis recusandae saepe laborum enim. Non consequatur voluptatem in aut quia quo quo. Commodi aliquid aut quaerat adipisci. Modi ea maxime doloribus qui sint.",
                            CreatedAt = new DateTime(2021, 3, 24, 14, 25, 37, 776, DateTimeKind.Unspecified).AddTicks(56),
                            CreatedBy = 1L,
                            IsDeleted = false,
                            Title = "in"
                        });
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Submission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastReviewed")
                        .HasColumnType("datetime2");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("LessonId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Thread", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<int>("EndPosition")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<long?>("LessonId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<int>("StartPosition")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("LessonId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.ThreadComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("ThreadId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ThreadId");

                    b.ToTable("ThreadComments");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Unit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AvatarId")
                        .HasColumnType("bigint");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Course", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("Codi.Core.DAL.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.CourseUser", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Course", "Course")
                        .WithMany("CourseUsers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.CourseRole", "CourseRole")
                        .WithMany()
                        .HasForeignKey("CourseRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.User", "User")
                        .WithMany("CourseUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("CourseRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.InvitedUser", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Project", "Project")
                        .WithMany("InvitedUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.User", "User")
                        .WithMany("InvitedUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Lesson", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.Unit", "Unit")
                        .WithMany("Lessons")
                        .HasForeignKey("UnitId");

                    b.Navigation("Course");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Project", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.User", "Owner")
                        .WithMany("Projects")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Submission", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.User", "Author")
                        .WithMany("Submissions")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Thread", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.User", "Author")
                        .WithMany("Threads")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.Lesson", "Lesson")
                        .WithMany("Threads")
                        .HasForeignKey("LessonId");

                    b.HasOne("Codi.Core.DAL.Entities.Project", "Project")
                        .WithMany("Threads")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Author");

                    b.Navigation("Lesson");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.ThreadComment", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.User", "Author")
                        .WithMany("ThreadComments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Codi.Core.DAL.Entities.Thread", "Thread")
                        .WithMany("ThreadComments")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Unit", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Course", "Course")
                        .WithMany("Units")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.User", b =>
                {
                    b.HasOne("Codi.Core.DAL.Entities.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Course", b =>
                {
                    b.Navigation("CourseUsers");

                    b.Navigation("Lessons");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Lesson", b =>
                {
                    b.Navigation("Threads");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Project", b =>
                {
                    b.Navigation("InvitedUsers");

                    b.Navigation("Threads");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Thread", b =>
                {
                    b.Navigation("ThreadComments");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.Unit", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Codi.Core.DAL.Entities.User", b =>
                {
                    b.Navigation("CourseUsers");

                    b.Navigation("InvitedUsers");

                    b.Navigation("Projects");

                    b.Navigation("Submissions");

                    b.Navigation("ThreadComments");

                    b.Navigation("Threads");
                });
#pragma warning restore 612, 618
        }
    }
}