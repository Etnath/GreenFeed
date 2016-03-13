namespace GreenFeed.Messages.Acknowledge
{
    public interface IAcknowledge
    {
        bool IsSuccess { get; }
        Status Status { get; }
    }
}
