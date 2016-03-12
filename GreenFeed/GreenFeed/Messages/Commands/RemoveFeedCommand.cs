using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
