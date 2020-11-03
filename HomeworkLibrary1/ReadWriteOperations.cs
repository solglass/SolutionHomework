using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class ReadWriteOperations
    {

        public static int[,] GenerateRandomArray(int[,] test, int nrand)
        {
            Random rand = new Random();
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    test[i, j] = rand.Next(nrand);

                }
            }
            return test;
        }

        public static int[] GenerateRandomArray(int[] test, int nrand)
        {
            Random rand = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rand.Next(nrand);
            }
            return test;
        }

        public static void WriteArrayToConsole(int[] test)
        {
            Console.WriteLine();
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();

        }
        public static void WriteArrayToConsole(int[,] test )
        {
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    Console.Write(test[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
