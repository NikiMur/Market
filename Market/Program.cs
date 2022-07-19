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


            void InputNumbers(int num)
            {
                int count = 0;
                int inputNum;
                string rowNum = String.Empty;
                Console.WriteLine("А теперь вводи целые числа, а если ошибешься не беда, я умный, кроме чисел ничего не записываю)))))");
                for (int i = 0; i < num; i++)
                {
                    do
                    {
                        Console.WriteLine("Введи целое число: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out inputNum));
                    if (inputNum > 0) count++;
                    rowNum += inputNum + " ";
                }
                Console.WriteLine("Вот числа которые ты ввел: ");
                Console.WriteLine(rowNum);
                PrintCount(count, num);
            }

            void RandomNumbers(int num)
            {
                int count = 0;
                Random rand = new Random();
                int randomNum;
                string rowNum = String.Empty;
                for (int i = 0; i < num; i++)
                {
                    randomNum = rand.Next(-9, 10);
                    if (randomNum > 0) count++;
                    rowNum += randomNum + " ";
                }
                Console.WriteLine("Вот числа которые я придумал: ");
                Console.WriteLine(rowNum);
                Console.WriteLine($"Из предуманных мной чисел положительных {count}");
            }
            

            void PrintCount(int count, int num)
            {
                string[] array = { "Все отрицательные", "Маловато положительных! Маловато будет!", "Ух ты! Все положительные" };
                int position = (count > 0 ? 1 : 0) + (count == num ? 1 : 0);
                Console.WriteLine();
                Console.WriteLine($"Из введенных положительных чисел {count}");
                Console.WriteLine();
                Console.WriteLine(array[position]);
            }
            Console.SetCursorPosition(saller.MassageX, saller.MassageY);
            CountPositiveNum();

            




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







