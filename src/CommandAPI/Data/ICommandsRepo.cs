using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandsRepo
    {
        IEnumerable<CommandItem> GetAllCommands();
        CommandItem GetCommandById(int id);
        void UpdateCommand(CommandItem cmd);
        void DeleteCommand(CommandItem cmd);
    }
}