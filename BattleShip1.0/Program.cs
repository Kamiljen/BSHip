using System;
using System.Threading;
using System.Text;

namespace BattleShip1._0
{
    class Program

    {
    public static void Main(string[] args)
        {
            var board = new Array[10, 10];
                
            for (int u = 0; u < 11; u++)
            {
                Console.Write("+");
                for (int k = 0; k < 10; k++)
                {
                    Console.Write("---+");
                }
                Console.WriteLine();
               
                if (u < 10)
                {
                    Console.Write("|");
                    for (int l = 0; l < 10; l++)
                    {
                        Console.Write("   |");
                    }
                    Console.WriteLine();
                }
               
               

            }

            //const int Rows = 10;
            //const int Columns = 10;
            //var output = new StringBuilder("+");
            //for (var i = 0; i < Columns; i++)
            //{
            //    output.Append("---+");
            //}
            //output.AppendLine();

            //for (int i = 0; i < Rows; i++)
            //{

            
            //    var top = "|";
            //    var bottom = "+";
            //    for (int j = 0; j < Rows; j++)
            //    {
            //        //const string body = "   ";
            //        //var east = cell.IsLinked(cell.East) ? " " : "|";

            //        //top += body + east;

            //        //var south = cell.IsLinked(cell.South) ? "   " : "---";
            //        //const string corner = "+";
            //        //bottom += south + corner;
            //    }
            //    output.AppendLine(top);
            //    output.AppendLine(bottom);
            //}

            //Console.Write(output.ToString());
            //const int width = 41;
            //const int height = 21;
            //for (int i = 0; i < height; i++)
            //{
            //    if (i <= 9)
            //    {
            //        Console.Write(" " + (i + 1) + " ");
            //    }
            //    else
            //    {
            //        Console.Write(i + 1 + " ");
            //    }
            //    for (int j = 0; j < width; j++)
            //    {

            //        if (i == 0 | i % 2 == 0)
            //        {
            //            if (j % 4 == 0)
            //            {
            //                Console.Write("+");
            //            }
            //            else
            //            {
            //                Console.Write("-");
            //            }
            //        }
            //        else
            //        {
            //            if (j == 0 | j == width - 1)
            //            {
            //                Console.Write("|");
            //            }
            //            else if (j % 4 == 0)
            //            {
            //                Console.Write("|");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //        //else if (i != 0 | i != height -1)
            //        //{
            //        //    if (j == 0 | j == width -1)
            //        //    {
            //        //        Console.Write("|");
            //        //    }
            //        //    else if (j % 4 == 0)
            //        //{
            //        //    Console.Write("|");
            //        //}
            //        //    else
            //        //    {
            //        //        Console.Write(" ");
            //        //    }
            //        //}


            //    }

            //    Console.WriteLine();
            //}
            Console.Read();
            //    const char toWrite = '*'; // Character to write on-screen.

            //    int x = 0, y = 0; // Contains current cursor position.

            //    Write(toWrite); // Write the character on the default location (0,0).

            //    while (true)
            //    {
            //        if (Console.KeyAvailable)
            //        {
            //            var command = Console.ReadKey().Key;

            //            switch (command)
            //            {
            //                case ConsoleKey.DownArrow:
            //                    y++;
            //                    break;
            //                case ConsoleKey.UpArrow:
            //                    if (y > 0)
            //                    {
            //                        y--;
            //                    }
            //                    break;
            //                case ConsoleKey.LeftArrow:
            //                    if (x > 0)
            //                    {
            //                        x--;
            //                    }
            //                    break;
            //                case ConsoleKey.RightArrow:
            //                    x++;
            //                    break;
            //            }

            //            Write(toWrite, x, y);
            //        }
            //        else
            //        {
            //            Thread.Sleep(100);
            //        }
            //    }
            //}

            //public static void Write(char toWrite, int x = 0, int y = 0)
            //{
            //    try
            //    {
            //        if (x >= 0 && y >= 0) // 0-based
            //        {
            //            Console.Clear();
            //            Console.SetCursorPosition(x, y);
            //            Console.Write(toWrite);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }
        }
    }
    }
