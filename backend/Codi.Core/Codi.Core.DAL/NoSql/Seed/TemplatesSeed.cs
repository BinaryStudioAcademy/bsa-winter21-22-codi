using Codi.Core.Common.Enums;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using File = Codi.Core.DAL.NoSql.Entities.File;

namespace Codi.Core.DAL.NoSql.Seed
{
    internal static class TemplatesSeed
    {
        public static async Task SeedTemplates(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            await SeedHtmlTemplate(fileRepository, templateRepository);
            await SeedCsharpTemplate(fileRepository, templateRepository);
            await SeedFsharpTemplate(fileRepository, templateRepository);
            await SeedPythonTemplate(fileRepository, templateRepository);
        }

        public static async Task EnsureTemplatesSeeded(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            var templates = await templateRepository.GetAllAsync(_ => true);

            foreach (var language in Enum.GetValues<Language>())
            {
                if (!templates.Any(t => t.Language == language))
                {
                    var seeder = GetSeederByLanguage(language);
                    if(seeder != null) await seeder.Invoke(fileRepository, templateRepository);
                }
            }
        }

        private static Func<IFileRepository, ITemplateRepository, Task>? GetSeederByLanguage(Language language)
        {
            return language switch
            {
                Language.CSharp => SeedCsharpTemplate,
                Language.FSharp => SeedFsharpTemplate,
                Language.JavaScript => SeedHtmlTemplate,
                Language.Python => SeedPythonTemplate,
                _ => null,
            };
        }

        private static async Task SeedHtmlTemplate(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            var files = new List<File>()
            {
                new File
                {
                    Name = "index.html",
                    Content =
@"<!DOCTYPE html>
<html>
  <head>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width"">
    <title>replit</title>
    <link href=""style.css"" rel=""stylesheet"" type=""text/css"" />
  </head>
  <body>
    Hello world
    <script src=""script.js""></script>
  </body>
</html>"
                },
                new File
                {
                    Name = "style.css",
                    Content =
@".hello-world {
    font-family: sans-serif;
    font-size: 42px;
}"
                },
                new File
                {
                    Name = "script.js",
                    Content = @"console.log(""Hello World!"");"
                }
            };

            await fileRepository.InsertManyAsync(files);

            var template = new Template
            {
                Name = "HTML, CSS, JS",
                Language = Language.HTML,
                Nodes = files.Select(f => new FSNode { Name = f.Name, Type = FSNodeType.File, FileId = f.Id }).ToList()
            };

            await templateRepository.InsertOneAsync(template);
        }

        private static async Task SeedCsharpTemplate(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            var files = new List<File>()
            {
                new File
                {
                    Name = "Program.cs",
                    Content = @"Console.WriteLine(""Hello, World!"");"
                },
                new File
                {
                    Name = "Desktop.csproj",
                    Content =
@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>"
                }
            };

            await fileRepository.InsertManyAsync(files);

            var template = new Template
            {
                Name = "C#",
                Language = Language.CSharp,
                Nodes = files.Select(f => new FSNode { Name = f.Name, Type = FSNodeType.File, FileId = f.Id }).ToList()
            };

            await templateRepository.InsertOneAsync(template);
        }

        private static async Task SeedFsharpTemplate(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            var files = new List<File>()
            {
                new File
                {
                    Name = "Program.fs",
                    Content = @"printfn ""Hello from F#"""
                },
                new File
                {
                    Name = "FSharp.fsproj",
                    Content =
@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <Compile Include=""Program.fs"" />
  </ItemGroup>

</Project>"
                }
            };

            await fileRepository.InsertManyAsync(files);

            var template = new Template
            {
                Name = "F#",
                Language = Language.FSharp,
                Nodes = files.Select(f => new FSNode { Name = f.Name, Type = FSNodeType.File, FileId = f.Id }).ToList()
            };

            await templateRepository.InsertOneAsync(template);
        }

        private static async Task SeedPythonTemplate(IFileRepository fileRepository, ITemplateRepository templateRepository)
        {
            var files = new List<File>()
            {
                new File
                {
                    Name = "main.py",
                    Content = @"from fancy_text import fancy

text = 'Hello World!'

print(text)
print(fancy.bold(text))"
                },
                new File
                {
                    Name = "requirements.txt",
                    Content = @"fancy-text"
                }
            };

            await fileRepository.InsertManyAsync(files);

            var template = new Template
            {
                Name = "Python",
                Language = Language.Python,
                Nodes = files.Select(f => new FSNode { Name = f.Name, Type = FSNodeType.File, FileId = f.Id }).ToList()
            };

            await templateRepository.InsertOneAsync(template);
        }
    }
}
