using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите длину массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0 || n > 100)
        {
            Console.WriteLine("Размерность массива должно быть не больше 100 и не меньше 0");
            Environment.Exit(0);
        }
        int[] numbers = new int[n];

        int Num = 0;
        for (int i = 0; i < n; i++)
        {
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num < -100 || Num > 100)
            {
                Console.WriteLine("Число должно быть не меньше -100 и не больше 100");
                Environment.Exit(0);
            }
            numbers[i] = Num;
        }

        Console.WriteLine("");

        bool result = false;
        for (int i = 0; i < (n - 1); i++)
        {
            if (result == false)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && numbers[i] == numbers[j] * -1)
                    {
                        result = true;
                        if (i < j)
                            Console.Write($"{i} {j}");
                        else
                            Console.Write($"{j} {i}");
                        break;
                    }
                }
            }
            else
                break;
        }
    }
}