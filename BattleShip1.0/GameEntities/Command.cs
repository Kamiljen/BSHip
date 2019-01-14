using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip1._0.GameEntities
{
    public class Command
    {
        public string CommandName { get; set; }
        public string CommandMessage { get; set; }
        public Command(string commandName, string commandMessage)
        {
            CommandName = commandName;
            CommandMessage = commandMessage;
        } 
    }
}
