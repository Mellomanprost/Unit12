using System;

namespace Unit12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int[] arrayUser = new int[] { 1, 2, 3, 5, 6, 7, 8 };
            int val;
            val = int.Parse(Console.ReadLine());
            GetIndex(arrayUser, val);
            Console.WriteLine("Итоговый массив:");
            for (int i = 0; i < arrayUser.Length; i++)
            {
                Console.Write(arrayUser[i] + " ");
            }
            Console.WriteLine("\n.");
        }

        static int GetIndex(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }
            return index;
        }
    }
}
