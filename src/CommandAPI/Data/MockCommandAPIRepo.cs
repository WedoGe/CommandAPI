using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{
                    HowTo="ls -lh",
                    Id=0,
                    Platform="Unix command line",
                    Title="list long format with readable file size"
                },
                new Command{
                    HowTo="ls -a",
                    Id=1,
                    Platform="Unix command line",
                    Title="list all files including hidden file starting with '.'"
                },
                new Command{
                    HowTo="ls --color",
                    Id=2,
                    Platform="Unix command line",
                    Title="colored list [=always/never/auto]"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                HowTo = "ls -a",
                Id = 1,
                Platform = "Unix command line",
                Title = "list all files including hidden file starting with '.'"
            };
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}