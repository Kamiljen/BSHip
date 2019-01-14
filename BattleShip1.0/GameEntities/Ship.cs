using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip1._0.GameEntities
{
    public class Ship
    {
        public string Name { get; set; }
        public int MaxLives { get; set; }
        public int CurrentLives { get; set; }
        public Status HitStatus { get; set; }
        public Status SinkStatus { get; set; }
    }
}
