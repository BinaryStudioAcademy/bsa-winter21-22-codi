﻿namespace Codi.Core.Common.DTO.Build;

public class StopProjectRequestDto
{
    public long ProjectId { get; set; }
    public string UserId { get; set; } = default!;
    public DateTime TimeStamp { get; set; }
}

