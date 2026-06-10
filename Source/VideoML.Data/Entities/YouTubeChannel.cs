namespace VideoML.Data.Entities;

public class YouTubeChannel
{
    public long ID { get; set; }

    public string ChannelId { get; set; } = null!;

    public string ChannelHandle { get; set; } = null!;

    public YouTubeChannelFlags ChannelFlags { get; set; }

    public string Title { get; set; } = null!;

    public string ChannelKind { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string? PlatformLabel { get; set; }

    public virtual ICollection<YouTubeVideo> YouTubeVideos { get; set; } = [];

    internal const string tableName = "YouTubeChannels";
}
