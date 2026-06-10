namespace VideoML.Data.Entities;

public class YouTubeVideoLabel
{
    public long ID { get; set; }

    public long YoutubeVideoID { get; set; }

    public string Label { get; set; } = null!;

    public string LabelSource { get; set; } = null!;

    public bool IsReviewed { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public virtual YouTubeVideo YouTubeVideo { get; set; } = null!;

    internal const string tableName = "YouTubeVideoLabels";
}
