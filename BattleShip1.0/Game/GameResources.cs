using System;
using System.Collections.Generic;
using System.Text;
using BattleShip1._0.GameEntities;

namespace BattleShip1._0.Game
{
    public class GameResources
    {
        public List<Ship> Ships { get; set; }
        
        public GameResources()
        {
            Ships = CreateShips();
        }
        public List<Ship> CreateShips()
        {
            return new List<Ship>()
            {
                new Ship{Name = "Carrier", MaxLives = 5, CurrentLives = 5, HitStatus = StatusHandler.GetStatus("241"), SinkStatus= StatusHandler.GetStatus("251")},
                new Ship{Name = "Battleship", MaxLives = 4, CurrentLives = 4, HitStatus = StatusHandler.GetStatus("242"), SinkStatus= StatusHandler.GetStatus("252")},
                new Ship{Name = "Destroyer", MaxLives = 2, CurrentLives = 2, HitStatus = StatusHandler.GetStatus("243"), SinkStatus= StatusHandler.GetStatus("253")},
                new Ship{Name = "Submarine", MaxLives = 3, CurrentLives = 3, HitStatus = StatusHandler.GetStatus("244"), SinkStatus= StatusHandler.GetStatus("254")},
                new Ship{Name = "Patrol Boat", MaxLives = 3, CurrentLives = 3, HitStatus = StatusHandler.GetStatus("245"), SinkStatus= StatusHandler.GetStatus("255")}
            };
        }
        public Cell[,] CreatePlayerBoard()
        {
            var board = new Cell[10, 10];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = new Cell()
                    {
                        Status = null,
                        Ship = null,
                    };
                }

            }
            var vertIndex = 0;
            foreach (var ship  in Ships)
            {
                for (int i = 0; i < ship.MaxLives; i++)
                {
                    board[vertIndex, i + vertIndex].Ship = ship;
                }
            }
            return board;
        }
        public Cell[,] CreateRandomBoard()
        {
            var board = new Cell[10, 10];
            //foreach (var ship in collection)
            //{

            //}
            return board;
        }
        public Cell[,] CreateEmptyBoard()
        {
            var board = new Cell[10, 10];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = new Cell()
                    {
                        Status = null,
                        Ship = null,
                    };
                }

            }
            return board;
        }
    }

    
}
