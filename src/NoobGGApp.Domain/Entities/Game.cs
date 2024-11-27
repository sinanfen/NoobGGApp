﻿using NoobGGApp.Domain.Common.Entities;

namespace NoobGGApp.Domain.Entities;

public sealed class Game : EntityBase<long>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public string Tags { get; set; }

    public ICollection<GameRegion> GameRegions { get; set; } = [];
}
