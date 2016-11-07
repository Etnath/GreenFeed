namespace GreenFeed.Messages.Acknowledge
{
    public class AddFeedAcknowledge : IAcknowledge
    {
        public bool IsSuccess { get; private set; }

        public Status Status { get; private set; }
        public int FeedCount { get; private set; }

        public AddFeedAcknowledge(int feedCount, bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = isSuccess;
            FeedCount = feedCount;
            Status = status;
        }       
    }
}
