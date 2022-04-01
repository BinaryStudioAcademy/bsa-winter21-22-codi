using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class CodiFileStorageSeed
    {
        public static async Task SeedData(CodiCoreContext codiCoreContext, IFileRepository fileRepository, 
            ITemplateRepository templateRepository, IProjectRepository projectRepository, IAppRepository appRepository)
        {
            await TemplatesSeed.SeedTemplates(fileRepository, templateRepository);
            await ProjectsSeed.SeedProjects(codiCoreContext, fileRepository, projectRepository, templateRepository);
            await AppsSeed.SeedApps(codiCoreContext, fileRepository, projectRepository, appRepository);
        }

        public static async Task EnsureTemplatesSeeded(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            await TemplatesSeed.EnsureTemplatesSeeded(fileRepository, templateRepository);
        }
    }
}
