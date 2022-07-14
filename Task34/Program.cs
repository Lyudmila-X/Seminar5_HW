// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
namespace Seminar5
{
    class Program
    {
        // Создаем метод, который будет создавать массив произвольного размера и заполнять его случайными 3-х значными числами
        public static int[] FillArray()
        {
            int count = new Random().Next(2, 11);
            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = new Random().Next(100, 1000);
            }
            return newArray;
        }
        // Метод, который выводит массив в консоль
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        // Метод, который считает, количество четных элементов в массиве
        public static int ElementCount(int[] incomeArray)
        {
            int count = 0;
            for (int i = 0; i < incomeArray.Length; i++)
            {
                if (incomeArray[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main()
        {
            int[] array = FillArray();
            PrintArray(array);
            Console.WriteLine("Количество четных элементов в массиве: " + ElementCount(array));
        }
    }
}