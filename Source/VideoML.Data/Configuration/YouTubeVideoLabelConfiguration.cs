using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoML.Data.Entities;

namespace VideoML.Data.Configuration;

internal sealed class YouTubeVideoLabelConfiguration : IEntityTypeConfiguration<YouTubeVideoLabel>
{
    public void Configure(EntityTypeBuilder<YouTubeVideoLabel> builder)
    {
        builder.ToTable(YouTubeVideoLabel.tableName);

        builder.HasKey(k => k.ID);

        builder.Property(p => p.Label)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(p => p.LabelSource)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasIndex(k => k.YoutubeVideoID)
            .IsUnique();

        builder.HasOne(f => f.YouTubeVideo)
            .WithOne(f => f.YouTubeVideoLabel)
            .HasForeignKey<YouTubeVideoLabel>(k => k.YoutubeVideoID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
