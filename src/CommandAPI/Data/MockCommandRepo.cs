using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandsRepo : ICommandsRepo
    {
        public void DeleteCommand(CommandItem cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CommandItem> GetAllCommands()
        {
            var commands = new List<CommandItem>{
                new CommandItem{
                    Command="ls -lh",
                    Id=0,
                    Platform="Unix command line",
                    HowTo="list long format with readable file size"
                },
                new CommandItem{
                    Command="ls -a",
                    Id=1,
                    Platform="Unix command line",
                    HowTo="list all files including hidden file starting with '.'"
                },
                new CommandItem{
                    Command="ls --color",
                    Id=2,
                    Platform="Unix command line",
                    HowTo="colored list [=always/never/auto]"
                }
            };

            return commands;
        }

        public CommandItem GetCommandById(int id)
        {
            return new CommandItem
            {
                Command = "ls -a",
                Id = 1,
                Platform = "Unix command line",
                HowTo = "list all files including hidden file starting with '.'"
            };
        }

        public void UpdateCommand(CommandItem cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}