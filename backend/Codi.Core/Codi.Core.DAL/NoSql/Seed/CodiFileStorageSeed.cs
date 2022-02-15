using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class CodiFileStorageSeed
    {
        public static void SeedData(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            TemplatesSeed.SeedTemplates(fileRepository, templateRepository).Wait();
        }
    }
}
