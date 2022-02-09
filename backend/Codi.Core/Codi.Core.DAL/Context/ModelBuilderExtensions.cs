﻿using Bogus;
using Codi.Core.DAL.Context;
using Codi.Core.DAL.Entities;
using Codi.Core.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Thread = Codi.Core.DAL.Entities.Thread;

namespace Codi.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        private static readonly string[] CourseRoles = {"admin", "member"};

        public static void Configure(this ModelBuilder modelBuilder)
        {
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDeletable).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleConfig).Assembly);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(42);

            var images = GenerateRandomImages(100);
            var users = GenerateRandomUsers(images, 50);
            var courses = GenerateRandomCourses(images, users, 20);
            var units = GenerateRandomUnits(courses, 40);
            var lessons = GenerateRandomLessons(units, 80);
            var courseRoles = GenerateRandomCourseRoles();
            var courseUsers = GenerateRandomCourseUsers(courses, users, courseRoles, 70);
            var submissions = GenerateRandomSubmissions(lessons, users, 100);
            var projects = GenerateRandomProjects(users, 50);
            var invitedUsers = GenerateRandomInvitedUsers(users, projects, 100);
            var threads = GenerateRandomThreads(users, projects, lessons, 80);
            var threadComments = GenerateRandomThreadComments(users, threads, 120);

            modelBuilder.Entity<Sample>().HasData(GenerateSamples());

            modelBuilder.Entity<Image>().HasData(images);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Course>().HasData(courses);
            modelBuilder.Entity<Unit>().HasData(units);
            modelBuilder.Entity<Lesson>().HasData(lessons);
            modelBuilder.Entity<CourseRole>().HasData(courseRoles);
            modelBuilder.Entity<CourseUser>().HasData(courseUsers);
            modelBuilder.Entity<Submission>().HasData(submissions);
            modelBuilder.Entity<Project>().HasData(projects);
            modelBuilder.Entity<InvitedUser>().HasData(invitedUsers);
            modelBuilder.Entity<Thread>().HasData(threads);
            modelBuilder.Entity<ThreadComment>().HasData(threadComments);
        }

        private static IList<Sample> GenerateSamples(int count = 10)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Sample>()
                .UseSeed(10)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Title, f => f.Lorem.Word())
                .RuleFor(e => e.Body, f => f.Lorem.Paragraph())
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(e => e.CreatedAt, f => f.Date.Past(2, new DateTime(2021, 7, 20)))
                .Generate(count);
        }

        public static IList<Image> GenerateRandomImages(int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Image>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.URL, f => f.Image.PicsumUrl())
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }

        public static IList<User> GenerateRandomUsers(IList<Image> images, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<User>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.UserName, f => f.Internet.UserName())
                .RuleFor(pi => pi.FirstName, f => f.Name.FirstName())
                .RuleFor(pi => pi.LastName, f => f.Name.LastName())
                .RuleFor(pi => pi.Bio, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.Email, f => f.Internet.Email())
                .RuleFor(pi => pi.AvatarId, f => f.PickRandom(images).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }

        public static IList<Course> GenerateRandomCourses(IList<Image> images, IList<User> users, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Course>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Name, f => string.Join("", f.Random.WordsArray(f.Random.Number(2, 4))))
                .RuleFor(pi => pi.DisplayName, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.Description, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.AvatarId, f => f.PickRandom(images).Id)
                .RuleFor(pi => pi.OwnerId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }

        public static IList<Unit> GenerateRandomUnits(IList<Course> courses, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Unit>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Title, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.CourseId, f => f.PickRandom(courses).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }

        public static IList<Lesson> GenerateRandomLessons(IList<Unit> units, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Lesson>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Title, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.Description, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.DueDate, f => f.Date.Future(2, new DateTime(2022, 2, 2)).OrNull(f, 0.05f))
                .RuleFor(pi => pi.IsPublished, f => f.Random.Bool())
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .FinishWith((f, l) =>
                {
                    var unit = f.PickRandom(units);
                    l.CourseId = unit.CourseId;
                    l.UnitId = unit.Id;
                })
                .Generate(count);
        }

        public static IList<CourseRole> GenerateRandomCourseRoles()
        {   int id = 1;
            return CourseRoles
                .Select(n => new CourseRole { Id = id++, Name = n, CreatedBy = 1, CreatedAt = new DateTime(2000, 1, 1) })
                .ToList();
        }

        public static IList<CourseUser> GenerateRandomCourseUsers(IList<Course> courses, IList<User> users, IList<CourseRole> roles, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<CourseUser>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.UserId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.CourseId, f => f.PickRandom(courses).Id)
                .RuleFor(pi => pi.CourseRoleId, f => f.PickRandom(roles).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count)
                .GroupBy(cu => new { cu.UserId, cu.CourseId }).Select(g => g.First())
                .ToList();
        }
        
        public static IList<Submission> GenerateRandomSubmissions(IList<Lesson> lessons, IList<User> users, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Submission>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.StartedDate, f => f.Date.Past(1, new DateTime(2020, 2, 2)))
                .RuleFor(pi => pi.SubmittedDate, f => f.Date.Between(new DateTime(2021, 1, 1), new DateTime(2022, 1, 1)))
                .RuleFor(pi => pi.LastReviewed, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2022, 2, 2)).OrNull(f, 0.1f))
                .RuleFor(pi => pi.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.LessonId, f => f.PickRandom(lessons).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }
        
        public static IList<Project> GenerateRandomProjects(IList<User> users, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Project>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Title, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.Description, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.IsPublic, f => f.Random.Bool())
                .RuleFor(pi => pi.OwnerId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }

        public static IList<InvitedUser> GenerateRandomInvitedUsers(IList<User> users, IList<Project> projects, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<InvitedUser>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.UserId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.ProjectId, f => f.PickRandom(projects).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count)
                .GroupBy(cu => new { cu.UserId, cu.ProjectId }).Select(g => g.First())
                .ToList();
        }

        public static IList<Thread> GenerateRandomThreads(IList<User> users, IList<Project> projects, IList<Lesson> lessons, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Thread>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.StartPosition, f => f.Random.Number(1, 500))
                .RuleFor(pi => pi.EndPosition, f => f.Random.Number(500, 1000))
                .RuleFor(pi => pi.IsResolved, f => f.Random.Bool())
                .RuleFor(pi => pi.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .FinishWith((f, t) =>
                {
                    if (f.Random.Bool())
                        t.LessonId = f.PickRandom(lessons).Id;
                    else
                        t.ProjectId = f.PickRandom(projects).Id;
                })
                .Generate(count);
        }

        public static IList<ThreadComment> GenerateRandomThreadComments(IList<User> users, IList<Thread> threads, int count)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<ThreadComment>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Body, f => f.Lorem.Sentences(f.Random.Number(1, 6)))
                .RuleFor(pi => pi.AuthorId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.ThreadId, f => f.PickRandom(threads).Id)
                .RuleFor(e => e.CreatedBy, f => f.Random.Number(1, 5))
                .RuleFor(pi => pi.CreatedAt, f => f.Date.Past(1, new DateTime(2022, 2, 2)))
                .Generate(count);
        }
    }
}