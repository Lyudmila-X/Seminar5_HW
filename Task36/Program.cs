// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
namespace Seminar5
{
    class Program
    {
        // Создаем метод, который будет создавать массив произвольного размера и заполнять его случайными числами
        public static int[] FillArray()
        {
            int count = new Random().Next(2, 11);
            int[] newArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = new Random().Next(-99, 100);
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
        // Метод, который считает сумму элементов стоящих на нечетных (с точки зрения наблюдателя) позициях в массиве 
        public static int OddPositionSum(int[] incomeArray)
        {
            int sum = incomeArray[0];
            for (int i = 2; i < incomeArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + incomeArray[i];
                }
            }
            return sum;
        }
         // Метод, который считает сумму элементов стоящих на нечетных (с точки зрения программы) позициях в массиве 
        public static int OddPositionVersion(int[] incomeArray)
        {
            int sum = incomeArray[1];
            for (int i = 2; i < incomeArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + incomeArray[i];
                }
            }
            return sum;
        }
        public static void Main()
        {
            // Уточняем, что значит нечетная позиция для пользователя
            Console.WriteLine("Укажите, с какой цифры для вас начинается нумерация массива: 1 или 0?");
            int numbering = Convert.ToInt32(Console.ReadLine()!);
            int[] array = FillArray();
            if (numbering ==0)
            {
                PrintArray(array);
                Console.WriteLine("Сумма элементов стоящих на нечетных позициях в массиве: " + OddPositionVersion(array));
            }
            else
            {
                if (numbering ==1)
                {
                    PrintArray(array);
                    Console.WriteLine("Сумма элементов стоящих на нечетных позициях в массиве: " + OddPositionSum(array));
                }
                else
                {
                    Console.WriteLine("Ошибка при вводе данных");
                }
            }           
        }
    }
}