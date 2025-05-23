﻿using GameLauncher.Dal.MsSQL.Entities.Author;
using GameLauncher.Dal.MsSQL.Entities.Classification;
using GameLauncher.Dal.MsSQL.Entities.Connections;
using GameLauncher.Dal.MsSQL.Entities.Game;
using GameLauncher.Dal.MsSQL.Entities.GameInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VladDataBase;Integrated Security=True;

namespace GameLauncher.Dal.MsSQL.EFCore;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) : base(options) { }

    public DbSet<AuthorEntity> Authors { get; set; }
    public DbSet<ClassificationEntity> Classifications { get; set; }
    public DbSet<GameClassificationEntity> GameClassification { get; set; }
    public DbSet<GameEntity> Games { get; set; }
    public DbSet<GameInfoEntity> GamesInfo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

}
