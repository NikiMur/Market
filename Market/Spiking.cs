using System;

namespace GameTestOne
{
    public class Spiking
    {

        void CountPositiveNum()
        {
            Console.Clear();
            Console.WriteLine("Привет дружок-пирожок! Хочешь поиграть в игру?");
            Console.WriteLine();
            Console.WriteLine("Если да, то введи слово 'YES'!");
            Console.WriteLine();
            string answer = Console.ReadLine().ToUpper();

            if (answer == "YES")
            {
                Console.WriteLine();
                Console.WriteLine("Я умею считать количество положительных чисел!");
                Console.WriteLine();
                Console.Write("Какое количество чисел ты хочешь проверить? В идеале если их будет не меньше 3! ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("И последний вопрос. Ты сам придумаешь числа или мне их придумать?");
                Console.Write("Если хочешь, что бы я придумал числа, введи с клавиатуры слово 'Please' ");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "please")
                {
                    RandomNumbers(number);
                }
                else if (answer2 != "please")
                {
                    InputNumbers(number);
                }
            }
            else if (answer != "YES") Console.WriteLine("Ну не хочешь, как хочешь!!! В следующий раз я могу не захотеть!");
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

      


    }


}


