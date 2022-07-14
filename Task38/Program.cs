// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
namespace Seminar5
{
    class Program
    {
        // Создаем метод, который будет создавать массив произвольного размера и заполнять его вещественными числами
        public static double[] FillArray()
        {
            int count = new Random().Next(2, 11);
            double[] newArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                int randomNum = new Random().Next(0, 2);
                if (randomNum == 0)
                {
                    newArray[i] = new Random().Next(-99, 100);
                }
                else
                {
                    newArray[i] = Math.Round((new Random().Next(-99, 100) + new Random().NextDouble()), 2);
                }
            }
            return newArray;
        }
        // Метод, который выводит массив в консоль
        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "   ");
            }
            Console.WriteLine();
        }
        // Метод поиска разницы между максимальным и минимальным элементами массива
        public static double MaxMinDiff(double[] incomeArray)
        {
            double min = incomeArray[0];
            double max = incomeArray[0];
            for (int i = 1; i < incomeArray.Length; i++)
            {
                if (incomeArray[i] > max)
                {
                    max = incomeArray[i];
                }
                if (incomeArray[i] < min)
                {
                    min = incomeArray[i];
                }
            }
            double diff = max - min;
            return (diff);
        }
        public static void Main()
        {
            double[] array = FillArray();
            PrintArray(array);
            Console.WriteLine("Разница между максимальным и минимальным элементами: " + MaxMinDiff(array));
        }
    }
}