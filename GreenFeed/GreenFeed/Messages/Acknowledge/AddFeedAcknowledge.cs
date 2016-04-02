namespace GreenFeed.Messages.Acknowledge
{
    public class AddFeedAcknowledge : IAcknowledge
    {
        public AddFeedAcknowledge(int feedCount, bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = isSuccess;
            FeedCount = feedCount;
            Status = status;
        }

        public bool IsSuccess { get; }

        public Status Status { get; }
        public int FeedCount { get; }
    }
}
