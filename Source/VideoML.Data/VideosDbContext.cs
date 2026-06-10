using Microsoft.EntityFrameworkCore;
using VideoML.Data.Entities;

namespace VideoML.Data;

public class VideosDbContext(DbContextOptions<VideosDbContext> options) : DbContext(options)
{
    public DbSet<YouTubeChannel> YouTubeChannels { get; set; }

    public DbSet<YouTubeVideo> YouTubeVideos { get; set; }

    public DbSet<YouTubeVideoLabel> YouTubeVideoLabels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(VideosDbContext).Assembly);
    }
}
