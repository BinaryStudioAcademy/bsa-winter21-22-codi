using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class CodiFileStorageSeed
    {
        public static async Task SeedData(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            await TemplatesSeed.SeedTemplates(fileRepository, templateRepository);
        }
    }
}
