namespace GreenFeed.Messages.Commands
{
    public class RemoveFeedCommand
    {
        public string Name { get; private set; }

        public RemoveFeedCommand(string name)
        {
            Name = name;
        }
    }
}
