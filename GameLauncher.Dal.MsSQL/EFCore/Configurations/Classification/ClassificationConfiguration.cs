using GameLauncher.Dal.MsSQL.Entities.Classification;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameLauncher.Dal.MsSQL.EFCore.Configurations.Classification;

public class ClassificationConfiguration : IEntityTypeConfiguration<ClassificationEntity>
{
    public void Configure(EntityTypeBuilder<ClassificationEntity> builder)
    {
        builder.ToTable("Classification").HasKey(c => c.Id);
        builder.Property(c => c.Id).HasColumnName("Id");
        builder.Property(c => c.Name).HasColumnName("Name");
        builder.HasMany(c => c.Games)
            .WithOne(g => g.Classification)
            .HasForeignKey(g => g.ClassificationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
