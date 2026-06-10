namespace VideoML.Data.Entities;

[Flags]
public enum YouTubeChannelFlags : int
{
    None = 0,
    PlatformHolder = 1 << 0,
    TrainingEnabled = 1 << 1,
    ClassificationEnabled = 1 << 2
}
