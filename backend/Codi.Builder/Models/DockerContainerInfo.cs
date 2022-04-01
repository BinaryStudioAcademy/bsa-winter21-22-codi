using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Models;

public class DockerContainerInfo
{
    public long ProjectId { get; set; }
    public string ImageSha256 { get; set; } = default!;
    public string ContainerName { get; set; } = default!;
    public string SourcePath { get; set; } = default!;
    public string UserId { get; set; } = default!;
    public Process Process { get; set; } = default!;
}
