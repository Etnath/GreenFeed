namespace GreenFeed.Messages.Acknowledge
{
    public class RemoveFeedAcknowledge : IAcknowledge
    {
        public bool IsSuccess { get; private set; }
        public Status Status { get; private set; }
        public int FeedCount { get; private set; }

        public RemoveFeedAcknowledge(int feedCount, bool isSuccess = true, Status status = Status.Ok)
        {
            IsSuccess = IsSuccess;
            FeedCount = feedCount;
            Status = status;
        }   
    }
}
