using Bogus;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class AppsSeed
    {
        public static async Task SeedApps(CodiCoreContext codiCoreContext, IFileRepository fileRepository,
             IProjectRepository projectsRepository, IAppRepository appRepository)
        {
            var random = new Randomizer();

            var apps = await codiCoreContext.Apps.ToListAsync();
            var projects = await projectsRepository.GetAllAsync(_ => true);
            var appsDocuments = new List<App>();

            foreach (var app in apps)
            {
                var project = random.ListItem(projects);

                appsDocuments.Add(new App
                {
                    Id = app.AppDocumentId,
                    ProjectId = project.Id,
                    Nodes = await fileRepository.DublicateFileStructure(project.Nodes),
                });

            }

            await appRepository.InsertManyAsync(appsDocuments);
        }
    }
}
