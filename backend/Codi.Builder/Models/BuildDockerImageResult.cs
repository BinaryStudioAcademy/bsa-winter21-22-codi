using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Models;

public class BuildDockerImageResult
{
    public long ProjectId { get; set; }
    public string UserId { get; set; } = default!;
    public string? Error { get; set; }
    public string? ImageSha256 { get; set; }
    public string SourcePath { get; set; } = default!;
    public BuildResult Result { get; set; }
}

