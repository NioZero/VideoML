namespace VideoML.Data.Entities;

public class YouTubeVideo
{
    public long ID { get; set; }

    public long YouTubeChannelID { get; set; }

    public string VideoId { get; set; } = null!;

    public YouTubeVideoFlags VideoFlags { get; set; }

    public DateTimeOffset PublishedAt { get; set; }

    public int DurationSeconds { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = string.Empty;

    public string Tags { get; set; } = string.Empty;

    public string? IgnoreReason { get; set; }

    public string? RawJson { get; set; }

    public virtual YouTubeChannel YouTubeChannel { get; set; } = null!;

    public virtual YouTubeVideoLabel? YouTubeVideoLabel { get; set; }

    internal const string tableName = "YouTubeVideos";
}
