namespace VideoML.Data.Entities;

[Flags]
public enum YouTubeVideoFlags : int
{
    None = 0,
    Ignored = 1 << 0,
    LiveBroadcast = 1 << 1,
    Short = 1 << 2,
    Premiere = 1 << 3,
    TrainingEnabled = 1 << 4,
    ClassificationEnabled = 1 << 5
}
