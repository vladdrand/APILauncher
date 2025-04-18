using GameLauncher.Dal.MsSQL.Entities.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameLauncher.Dal.MsSQL.EFCore.Configurations.Connections;

public class GameClassificationsConfiguration : IEntityTypeConfiguration<GameClassificationEntity>
{
    public void Configure(EntityTypeBuilder<GameClassificationEntity> builder)
    {
        builder.ToTable("GameClassificationsMtoM");
        builder.HasKey(gc => gc.GameId);
        builder.HasKey(gc => gc.ClassificationId);
        builder.HasOne(gc => gc.Game)
            .WithMany(g => g.Classification)
            .HasForeignKey(gc => gc.GameId)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(gc => gc.Classification)
            .WithMany(c => c.Games)
            .HasForeignKey(gc => gc.ClassificationId)
            .OnDelete(DeleteBehavior.ClientSetNull);

    }
}
