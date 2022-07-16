using System;
using System.Collections.Generic;
using System.Threading;

namespace GameTestOne
{

    public class Saller
    {

        public class Part
        {
            public int x, y, oldx, oldy;

        }
        public int MassageX, MassageY;
        public List<Part> parts = new List<Part>();
    }
    class Program
    {

        public static bool isStarted;
        public static int width = 120, height =28;
        public static Saller saller;
    




        public static void Init()
        {
            saller = new Saller() { MassageX = width -119, MassageY = height -8, parts = new List<Saller.Part>() { new Saller.Part() { x = (width) - 119, y = height -27, oldx = (width / 2) - 1, oldy = height / 2 } } };
            Console.CursorVisible = false;
            isStarted = true;

        }


        public static void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (j == 0 && i == 0)
                    {
                        Console.Write("╔");
                        continue;
                    }
                    if (j == width - 1 && i == 0)
                    {
                        Console.Write("╗");
                        continue;
                    }
                    if (j == 0 && i == height - 1)
                    { Console.Write("╚");
                      continue; 
                    }
                    if (j == width - 1 && i == height - 1)
                    {
                        Console.Write("╝");
                        continue;
                    }

                    if (i == 0 || i == height - 1) 
                    {
                        Console.Write("═");
                        continue;
                    }
                   
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("║");
                    }
                    if (i == height - 9)
                    {
                        Console.Write("═");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }



            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
            Console.Write("Привет Добро Пожаловать в магазин Шота у Ашота");
            for (int i = 0; i < saller.parts.Count; i++)
            {
                Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y);
                Console.Write("1 ШМОТКА");
                Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y+1);
                Console.Write("2 ШМОТКА");
                Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 2);
                Console.Write("3 ШМОТКА");
                Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 3);
                Console.Write("4 ШМОТКА");
                Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 4);
                Console.Write("5 ШМОТКА");
            }
            
        }





        static void Main(string[] args)
        {

            Init();
            while (isStarted)
            {
               
                Draw();
                Thread.Sleep(1000);

            }
        }
    }
}







