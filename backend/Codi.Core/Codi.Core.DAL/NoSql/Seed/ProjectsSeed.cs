﻿using Bogus;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project = Codi.Core.DAL.NoSql.Entities.Project;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class ProjectsSeed
    {
        public static async Task SeedProjects(CodiCoreContext codiCoreContext, IFileRepository fileRepository,
            IProjectRepository projectsRepository, ITemplateRepository templateRepository)
        {
            var random = new Randomizer();

            var projects = await codiCoreContext.Projects.ToListAsync();
            var templates = await templateRepository.GetAllAsync(_ => true);
            var projectDocuments = new List<Project>();

            foreach (var project in projects)
            {
                var template = random.ListItem(templates);

                projectDocuments.Add(new Project
                {
                     Id = project.ProjectDocumentId,
                     TemplateId = template.Id,
                     Nodes = await fileRepository.DublicateFileStructure(template.Nodes),
                });

            }

            await projectsRepository.InsertManyAsync(projectDocuments);
        }
    }
}
