using GameLauncher.Dal.MsSQL.Entities.GameInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameLauncher.Dal.MsSQL.EFCore.Configurations.GameInfo;

public class GameInfoConfiguration : IEntityTypeConfiguration<GameInfoEntity>
{
    public void Configure(EntityTypeBuilder<GameInfoEntity> builder)
    {
        builder.ToTable("GameInfo").HasKey(i => i.Id);
        builder.Property(i => i.Id).HasColumnName("Id");
        builder.Property(i => i.Description).HasMaxLength(500).HasColumnName("Description");
        builder.Property(i => i.SystemRequirements).HasColumnName("SystemRequirements");
    }
}
