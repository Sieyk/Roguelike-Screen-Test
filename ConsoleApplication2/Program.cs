using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint yPos = 13;
            uint xPos = 40;
            Random rnd = new Random();
            String temp = "";
            String[][] screen = new String[25][];
            Player player = new Player(yPos, xPos);
            Enemy[] enemy = new Enemy[4];
            for (int i = 0; i <= 3; i++)
            {
                enemy[i] = new Enemy((uint)(rnd.Next((int)(yPos / (i+1)), (int)(yPos) + i)), (uint)(rnd.Next(6, 50)));
            }
            for (int y = 0; y <= 24; y++)
            {
                screen[y] = new String[79];
                for (int x = 0; x <= 78; x++)
                {
                    screen[y][x] = ".";
                }
            }
            screen[player.getY()][player.getX()] = "@";
            for (uint i = 0; i < enemy.Length; i++)
            {
                screen[enemy[i].getY()][enemy[i].getX()] = "X";
            }

            for (; ; )
            {
                refresh(screen);
                ConsoleKeyInfo name = Console.ReadKey(true);
                movement(ref name, ref temp, ref screen, ref player);
                for (int i = 0; i < enemy.Length; i++)
                {
                    temp = screen[enemy[i].getY()][enemy[i].getX()];
                    screen[enemy[i].getY()][enemy[i].getX()] = ".";
                    enemy[i].randomMove();
                    screen[enemy[i].getY()][enemy[i].getX()] = "X";
                }
                refresh(screen);
            }
        }

        public static void movement(ref ConsoleKeyInfo name, ref String temp, ref String[][] screen, ref Player player)
        {
            if (name.Key == System.ConsoleKey.W || name.Key == System.ConsoleKey.NumPad8 || name.Key == System.ConsoleKey.UpArrow)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.yPosMinus();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.A || name.Key == System.ConsoleKey.NumPad4 || name.Key == System.ConsoleKey.LeftArrow)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosMinus();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.S || name.Key == System.ConsoleKey.NumPad2 || name.Key == System.ConsoleKey.DownArrow)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.yPosAdd();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.D || name.Key == System.ConsoleKey.NumPad6 || name.Key == System.ConsoleKey.RightArrow)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosAdd();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.NumPad1)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosMinus();
                player.yPosAdd();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.NumPad3)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosAdd();
                player.yPosAdd();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.NumPad7)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosMinus();
                player.yPosMinus();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.NumPad9)
            {
                temp = screen[player.getY()][player.getX()];
                screen[player.getY()][player.getX()] = ".";
                player.xPosAdd();
                player.yPosMinus();
                screen[player.getY()][player.getX()] = "@";
            }
            else if (name.Key == System.ConsoleKey.NumPad5)
            {
            }
        }

        public static void refresh(String[][] screen)
        {
            String output = "";
            for (int y = 0; y <= 24; y++)
            {
                for (int x = 0; x <= 78; x++)
                {
                    output += screen[y][x];
                }
                if (y < 24)
                    output += "\n";
            }
            Console.Clear();
            Console.Out.Write(output);
        }
    }
}
