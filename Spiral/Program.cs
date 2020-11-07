using System;

namespace Улитка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int result = 1;
            int cycleСounter = -1;

            Console.WriteLine("Write numbers of rows");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Write number correctly");
            }

            Console.WriteLine("Write numbers of columns");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Write number correctly");
            }

            int[,] arr = new int[n, m];
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            do
            {
                cycleСounter++;
                int  i= 0 + cycleСounter;

                for (int j = columns - 1 - cycleСounter; j >= 0 + cycleСounter; j--)
                {
                    if (result - 1 == arr.Length)
                    {
                        break;
                    }
                    arr[i, j] = result;
                    result++;
                }
                for (int j = 1 + cycleСounter; j < rows - cycleСounter; j++)
                {
                    if (result - 1 == arr.Length)
                    {
                        break;
                    }
                    arr[j, cycleСounter] = result;
                    result++;
                }

                i  = rows - cycleСounter - 1;

                for (int j = 1 + cycleСounter; j < columns - cycleСounter; j++)
                {
                    if (result - 1 == arr.Length)
                    {
                        break;
                    }
                    arr[i, j] = result;
                    result++;
                }

                i = columns - cycleСounter - 1;

                for (int j = rows - 2 - cycleСounter; j >= 1 + cycleСounter; j--)
                {
                    if (result - 1 == arr.Length)
                    {
                        break;
                    }
                    arr[j, i] = result;
                    result++;
                }
            } while (result - 1 < arr.Length);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"\t {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
