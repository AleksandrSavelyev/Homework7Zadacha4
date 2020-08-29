using System;

namespace SumDiapozon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число:\t");
            int num1 = VerNum();
            Console.Write("введите второе число:\t");
            int num2 = VerNum();
            int sum = 0;
            if (num1 < num2)
                sum = SumNum(num1, num2);
            else if (num1 > num2)
                sum = SumNum(num2, num1);
            else
                Console.WriteLine("между чисел нету промежутка");
            Console.WriteLine($"сумма чисел от {num1} до {num2} равна {sum}");

        }
        static int VerNum()
        {
            int num = 0;
            bool i = false;
            while (i == false)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                    break;
                else
                    Console.Write("ненверные данные\nповторите ввод:\t");
            }
            return num;
        }
        static int SumNum(int num1, int num2)
        {
            if (num1 == num2)
                return num2;
            else
                return num1 + SumNum(num1 + 1, num2);
        }
    }
}

