using Bogus;
using Codi.Core.DAL.Context;
using Codi.Core.DAL.Entities;
using Codi.Core.DAL.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.DAL.Context
{
    public static class ModelBuilderExtensions
    {
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
            var images = GenerateRandomImages(100);
            var users = GenerateRandomUsers(images, 50);
            var courses = GenerateRandomCourses(images, users, 20);

            modelBuilder.Entity<Sample>().HasData(GenerateSamples());
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

        public static IList<Image> GenerateRandomImages(int count = 50)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Image>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.URL, f => f.Image.PicsumUrl())
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .Generate(count);
        }

        public static IList<User> GenerateRandomUsers(IList<Image> images, int count = 50)
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
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .Generate(count);
        }

        public static IList<Course> GenerateRandomCourses(IList<Image> images, IList<User> users, int count = 10)
        {
            Faker.GlobalUniqueIndex = 1;

            return new Faker<Course>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Name, f => string.Join("", f.Random.WordsArray(f.Random.Number(2, 4))))
                .RuleFor(pi => pi.DisplayName, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.Description, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.AvatarId, f => f.PickRandom(images).Id)
                .RuleFor(pi => pi.OwnerId, f => f.PickRandom(users).Id)
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .Generate(count);
        }

        public static IList<Lesson> GenerateRandomLessons(IList<Course> courses, out IList<Unit> units, int count = 100)
        {
            Faker.GlobalUniqueIndex = 1;
            units = new List<Unit>();

            return new Faker<Lesson>()
                .RuleFor(pi => pi.Id, f => f.IndexGlobal)
                .RuleFor(pi => pi.Title, f => f.Lorem.Sentence())
                .RuleFor(pi => pi.Description, f => f.Lorem.Sentences(f.Random.Number(1, 5)))
                .RuleFor(pi => pi.DueDate, f => f.Date.Future(2).OrNull(f, 0.05f))
                .RuleFor(pi => pi.IsPublished, f => f.Random.Bool())
                .RuleFor(pi => pi.CourseId, f => f.PickRandom(courses).Id)
                //.RuleFor(pi => pi.UnitId, f => {
                //    var unit = new Unit { Title = f.Lorem.Sentence(), CreatedAt = DateTime.Now };
                //    units.Add(unit);
                //    return unit.Id;
                //})
                .RuleFor(pi => pi.CreatedAt, f => DateTime.Now)
                .Generate(count);
        }
    }
}
