﻿namespace WebApi.Core.DTOS;

public abstract class BaseDto
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
