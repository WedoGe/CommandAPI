using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandsRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}