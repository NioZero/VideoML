using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoML.Data.Entities;

namespace VideoML.Data.Configuration;

internal sealed class YouTubeChannelConfiguration : IEntityTypeConfiguration<YouTubeChannel>
{
    public void Configure(EntityTypeBuilder<YouTubeChannel> builder)
    {
        builder.ToTable(YouTubeChannel.tableName);

        builder.HasKey(k => k.ID);

        builder.Property(p => p.ChannelId)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.ChannelHandle)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.ChannelFlags)
            .HasConversion<int>()
            .IsRequired();

        builder.Property(p => p.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(p => p.ChannelKind)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.DefaultDomain)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.PlatformLabel)
            .HasMaxLength(100);

        builder.HasIndex(k => k.ChannelId)
            .IsUnique();

        builder.HasIndex(k => k.ChannelHandle);
    }
}
