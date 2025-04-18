using GameLauncher.Dal.MsSQL.Entities.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameLauncher.Dal.MsSQL.EFCore.Configurations.Author;

public class AuthorConfiguration : IEntityTypeConfiguration<AuthorEntity>
{
    public void Configure(EntityTypeBuilder<AuthorEntity> builder)
    {
        builder.ToTable("Author").HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("Id");
        builder.Property(a => a.Name).HasColumnName("Name");
        builder.HasMany(a => a.Games)
            .WithOne(g => g.Author)
            .HasForeignKey(g => g.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
