namespace GreenFeed.Messages.Commands
{
    public class AddFeedCommand
    {
        public string Name { get; private set; }
        public string Url { get; private set; }

        public AddFeedCommand(string name, string url)
        {
            Name = name;
            Url = url;
        }       
    }
}
