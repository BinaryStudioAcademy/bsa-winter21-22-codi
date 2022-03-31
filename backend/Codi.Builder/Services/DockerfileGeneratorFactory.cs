using Codi.Builder.Interfaces;
using Codi.Builder.Services.DockerfileGenerators;
using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Services;

public class DockerfileGeneratorFactory : IDockerfileGeneratorFactory
{
    private readonly IServiceProvider _serviceProvider;

    public DockerfileGeneratorFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IDockerfileGenerator GetDockerfileGenerator(Language language)
    {
        return language switch
        {
            Language.CSharp => _serviceProvider.GetRequiredService<CSharpDockerfileGenerator>(),
            Language.Python => _serviceProvider.GetRequiredService<PythonDockerfileGenerator>(),
            Language.Goloang => _serviceProvider.GetRequiredService<GolangDockerfileGenerator>(),
            _ => throw new ArgumentException("This language is not supported yet"),
        };
    }
}