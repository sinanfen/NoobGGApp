﻿using NoobGGApp.Domain.Common.Entities;
using TSID.Creator.NET;

namespace NoobGGApp.Domain.Entities;

public sealed class Game : EntityBase<long>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }

    public Game()
    {
        Id = TsidCreator.GetTsid().ToLong();
    }
}
