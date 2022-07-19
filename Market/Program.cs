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
        public static int width = 120, height = 29;
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
            Console.WriteLine("Привет Путник! Хочешь купить новое снаряжение?          ");
            Console.ReadKey();

             int Money = 300;
            void CountPositiveNum()
            {
                
                int price = 100;
                Console.SetCursorPosition(saller.MassageX + 105, saller.MassageY - 19);
                Console.WriteLine($"gold = {Money}");
                Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                Console.WriteLine("Если желаешь заглянуть в мою лавочку введи 'YES'!                               ") ;
                Console.WriteLine();
                Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                string answer = Console.ReadLine().ToUpper();
                Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                Console.WriteLine("Смотри какой у меня замечательный выбор, но найдутся ли у тебя монеты ?");


                if (answer == "YES")
                {

                    Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                    Console.WriteLine("Введи номер предмета который ты хотел бы купить");
                    Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                    Console.WriteLine("                                  ");
                    for (int i = 0; i < saller.parts.Count; i++)
                    {
                        
                        Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y);
                        Console.Write("1 ШМОТКА");
                        Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 1);
                        Console.Write("2 ШМОТКА");
                        Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 2);
                        Console.Write("3 ШМОТКА");
                        Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 3);
                        Console.Write("4 ШМОТКА");
                        Console.SetCursorPosition(saller.parts[i].x, saller.parts[i].y + 4);
                        Console.Write("5 ШМОТКА");
                    }
                    Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                    string answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        if (price > Money)
                        {
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" К сожалению твоих денюжек не хватает                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.ReadKey();
                            while (true)
                            {
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                {
                                    Init();
                                    CountPositiveNum();
                                    break;
                                }
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    break;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Money = Money-price;
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" ООООООО Эта Вещь очень Хороша поздравляю с покупкой                     ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                            Console.WriteLine("                                                                 ");
                        }
                    }
                    
                        else if (answer2 == "2")
                    {
                        if (price > Money)
                        {
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" К сожалению твоих денюжек не хватает                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.ReadKey();
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine("Желаешь прикупить что то еще? нажми ENTER для продолжения или ESC для  выхода ");
                            while (true)
                            {
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                {
                                    Init();
                                    CountPositiveNum();
                                    break;
                                }
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    break;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Money = Money - price;
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" Когда то и я ходил с НИМ пока мне не прострелили колено....              ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                            Console.WriteLine("                                                                 ");
                        }
                    }
                        else if (answer2 == "3")
                    {
                        if (price > Money)
                        {
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" К сожалению твоих денюжек не хватает                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.ReadKey();
                            while (true)
                            {
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                {
                                    Init();
                                    CountPositiveNum();
                                    break;
                                }
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    break;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Money = Money - price;
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" ХМ Сомнительное преобритение                                             ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                            Console.WriteLine("                                                                 ");
                        }
                    }
                        else if (answer2 == "4")
                    {
                        if (price > Money)
                        {
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" К сожалению твоих денюжек не хватает                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.ReadKey();
                            while (true)
                            {
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                {
                                    Init();
                                    CountPositiveNum();
                                    break;
                                }
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    break;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Money = Money - price;
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" ООООООО Это была моя любимая ВЕЩЬ                                        ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                            Console.WriteLine("                                                                 ");
                        }
                    }

                        else if (answer2 == "5")
                    {
                        if (price > Money)
                        {
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" К сожалению твоих денюжек не хватает                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.ReadKey();
                            while (true)
                            {
                                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                {
                                    Init();
                                    CountPositiveNum();
                                    break;
                                }
                                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                                {
                                    break;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Money = Money - price;
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                            Console.WriteLine(" а ты настрое СЕРЬЕЗНО                                                   ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 1);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(saller.MassageX, saller.MassageY + 2);
                            Console.WriteLine("                                                                 ");
                        }
                    }

                    Console.ReadKey();
                    Console.SetCursorPosition(saller.MassageX, saller.MassageY + 3);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(saller.MassageX+1, saller.MassageY);
                    Console.WriteLine("Желаешь прикупить что то еще? нажми ENTER для продолжения или ESC для  выхода ");
                    while (true)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Init();
                            CountPositiveNum();
                            break;
                        }
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            break;
                            return;
                        }
                    }
                }

                else if (answer != "YES")
                {
                   
                    Console.SetCursorPosition(saller.MassageX, saller.MassageY);
                    Console.WriteLine("Ну не хочешь, как хочешь!!! В следующий раз я могу не захотеть!"                                  );
                    Console.SetCursorPosition(saller.MassageX , saller.MassageY+1);
                    Console.WriteLine("                                                         ");

                    
                }

            }


            




        }





        static void Main(string[] args)
        {

            Init();
            while (isStarted)
            {

                Draw();
                Thread.Sleep(10000000);

            }
        }
    }
}







