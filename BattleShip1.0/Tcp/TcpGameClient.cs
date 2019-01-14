using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Net.Sockets;


namespace BattleShip1._0.Tcp
{
    public class TcpGameClient
    {
        static Game.Game game;
        static int[] cords = new int[2];
        static int BadRequestsLeft = 5;
        static TcpClient client;

        public static void PlayGame(string host, int port)
        {
            game = new Game.Game("Alexander");
            

            using (var client = NewConnection(host, port))
            using (var networkStream = client.GetStream())
            using (StreamReader reader = new StreamReader(networkStream, Encoding.ASCII))
            using (StreamWriter writer = new StreamWriter(networkStream, Encoding.ASCII) { AutoFlush = true })
            {

            }
          
        }

        #region helpers

        static TcpClient NewConnection(string host, int port)
        {
            bool isConnected = false;
            while (!isConnected)
            {
                try
                {
                    client = new TcpClient(host, port);
                    isConnected = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Reenter host:");
                    host = Console.ReadLine();
                    Console.WriteLine("Reenter port:");
                    port = int.Parse(Console.ReadLine());
                }
            }
        }
        #endregion
    }
}
