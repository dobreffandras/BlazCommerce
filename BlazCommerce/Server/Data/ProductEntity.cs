﻿namespace BlazCommerce.Server.Data;

public class ProductEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; } // TODO turn to multiple
}