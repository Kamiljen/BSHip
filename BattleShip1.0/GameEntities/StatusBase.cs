using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip1._0.GameEntities
{
    public class StatusBase
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public StatusBase(string statusCode, string statusMessage)
        {
            StatusCode = statusCode;
            StatusMessage = statusMessage;
        }
        public void RecieveStatus()
        {

        }

        public void SendStatus()
        {
                
        }
    }
}
