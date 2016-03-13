namespace GreenFeed.Messages.Commands
{
    public class RemoveFeedCommand
    {
        public RemoveFeedCommand(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
