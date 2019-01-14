using BattleShip1._0.GameEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip1._0.Game
{
    public class Game
    {
        public Cell[,] PlayerBoard { get; set; }
        public Cell[,] OpponentBoard { get; set; }
        public string PlayerName { get; set; }
        public bool MyProperty { get; set; }

        public Game(string playerName)
        {
            var gameSeed = new GameResources();
            PlayerBoard = gameSeed.CreatePlayerBoard();
            OpponentBoard = gameSeed.CreateEmptyBoard();
            PlayerName = playerName;
        }
        public void HandleResponse(string response)
        {
            
        }
        public void HandleCommand()
        {

        }
        public void HandleStatusCode()
        {

        }
    }
}
