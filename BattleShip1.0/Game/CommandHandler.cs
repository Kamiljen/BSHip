using BattleShip1._0.GameEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip1._0.Game
{
    public class CommandHandler
    {
        private List<Command> Commands { get; set; }

        public CommandHandler(string playerName)
        {
            Commands = new List<Command>();
            var START = new Command("START","");
            var FIRE = new Command("FIRE", "");
            var HELO = new Command("HELO", "");
            var HELP = new Command("HELP", "");
            var QUIT = new Command("QUIT", "");
        }
    }
}
