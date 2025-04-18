using GameLauncher.Dal.MsSQL.Entities.Game;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameLauncher.Dal.MsSQL.EFCore.Configurations.Game;

public class GameConfiguration : IEntityTypeConfiguration<GameEntity>
{
    public void Configure(EntityTypeBuilder<GameEntity> builder)
    {
        builder.ToTable("Game").HasKey(g => g.Id);
        builder.Property(g => g.Id).HasColumnName("Id");
        builder.Property(g => g.Name).HasColumnName("Name");
        builder.Property(g => g.Cost).HasColumnName("Cost");
        builder.HasOne(g => g.Info)
            .WithOne(i => i.Game)
            .HasForeignKey("InfoId")
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(g => g.Author)
            .WithMany(a => a.Games)
            .HasForeignKey(g => g.Id);
        builder.HasMany(g => g.Classification)
            .WithOne(gc => gc.Game)
            .HasForeignKey(gc => gc.GameId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
