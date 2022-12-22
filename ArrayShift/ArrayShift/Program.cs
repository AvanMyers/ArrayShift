using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayLangth = 10;
            int numberOfShifts = 0;
            int minRandom = 0;
            int maxRandom = 10;
            int rememberedNumber = 0;
            int[] array = new int[arrayLangth];

            Console.Write("[ ");

            for (int i = 0; i < arrayLangth; i++)
            {
                array[i] = random.Next(minRandom, maxRandom);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("]");
            Console.WriteLine("Введите количество сдвигов в массиве:");
            numberOfShifts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfShifts; i++)
            {
                rememberedNumber = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];

                    if (j == array.Length - 2)
                    {
                        array[j + 1] = rememberedNumber;
                    }
                }
            }

            Console.Write("[ ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("]");
            Console.ReadKey();
        }
    }
}
