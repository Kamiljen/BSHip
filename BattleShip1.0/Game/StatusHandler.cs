using BattleShip1._0.GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip1._0.Game
{
    public static class StatusHandler
    {
        //private static List<Status> Statuses { get; set; }
        private static string PlayerName { get; set; }


        private static List<Status> statuses = new List<Status>() {
               new Status{StatusCode = "210", StatusMessage ="BATTLESHIP/1.0"},
                new Status{StatusCode = "220", StatusMessage =$"{PlayerName}"},
                new Status{StatusCode = "221", StatusMessage ="Client Starts"},
                new Status{StatusCode = "222", StatusMessage ="Host Starts"},
                new Status{StatusCode = "230", StatusMessage ="Miss!"},
                new Status{StatusCode = "241", StatusMessage ="You hit my Carrier"},
                new Status{StatusCode = "242", StatusMessage ="You hit my Battleship"},
                new Status{StatusCode = "243", StatusMessage ="You hit my Destroyer"},
                new Status{StatusCode = "244", StatusMessage ="You hit my Submarine"},
                new Status{StatusCode = "245", StatusMessage ="You hit my Patrol Boat"},
                new Status{StatusCode = "251", StatusMessage ="You sunk my Carrier"},
                new Status{StatusCode = "252", StatusMessage ="You sunk my Battleship"},
                new Status{StatusCode = "253", StatusMessage ="You sunk my Destroyer"},
                new Status{StatusCode = "254", StatusMessage ="You sunk my Submarine"},
                new Status{StatusCode = "255", StatusMessage ="You sunk my Patrol Boat"},
                new Status{StatusCode = "260", StatusMessage ="You win!"},
                new Status{StatusCode = "270", StatusMessage ="Connection closed"},
                new Status{StatusCode = "500", StatusMessage ="Syntax error"},
                new Status{StatusCode = "501", StatusMessage ="Sequence error"},
        };

        //public string RecievedStatus(string statusCode)
        //{

        //}
        //public string SendStatus(string statusCode)
        //{
        //    return Statuses.SingleOrDefault(x => x.StatusCode == statusCode).StatusMessage;
        //}
        public static Status GetStatus(string statusCode)
        {
            return statuses.SingleOrDefault(x => x.StatusCode == statusCode);
        }
    }
}
