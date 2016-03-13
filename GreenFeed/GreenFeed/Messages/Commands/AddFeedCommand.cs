namespace GreenFeed.Messages.Commands
{
    public class AddFeedCommand
    {
        public AddFeedCommand(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public string Name { get; }
        public string Url { get; }
    }
}
