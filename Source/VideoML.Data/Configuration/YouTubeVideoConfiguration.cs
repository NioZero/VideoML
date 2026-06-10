using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoML.Data.Entities;

namespace VideoML.Data.Configuration;

internal sealed class YouTubeVideoConfiguration : IEntityTypeConfiguration<YouTubeVideo>
{
    public void Configure(EntityTypeBuilder<YouTubeVideo> builder)
    {
        builder.ToTable(YouTubeVideo.tableName);

        builder.HasKey(k => k.ID);

        builder.Property(p => p.VideoId)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.VideoFlags)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(p => p.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(p => p.Description)
            .IsRequired();

        builder.Property(p => p.Tags)
            .IsRequired();

        builder.Property(p => p.IgnoreReason)
            .HasMaxLength(500);

        builder.Property(p => p.RawJson);

        builder.HasIndex(k => k.VideoId)
            .IsUnique();

        builder.HasOne(f => f.YouTubeChannel)
            .WithMany(f => f.YouTubeVideos)
            .HasForeignKey(k => k.YouTubeChannelID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
