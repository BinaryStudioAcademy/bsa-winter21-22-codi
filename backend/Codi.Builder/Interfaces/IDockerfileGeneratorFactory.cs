using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Interfaces;

public interface IDockerfileGeneratorFactory
{
    IDockerfileGenerator GetDockerfileGenerator(Language language);
}