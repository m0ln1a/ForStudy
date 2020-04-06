using System;

namespace Rud_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { {0, 1, 1, 3, 1, 1},
                              {1, 0, 1, 3, 3, 1 },
                              {1, 1, 0, 1, 3, 0 },
                              {0, 0, 1, 0, 1, 0 },
                              {1, 0, 0, 1, 0, 0 },
                              {1, 1, 3, 3, 3, 0 } };

            PrintTable(matrix);

            Console.WriteLine("Кол-во команд, у которых побед больше, чем поражений: " + GetWinTeams(matrix));
            Console.ReadKey();
        }

        static void PrintTable(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));

            Console.WriteLine();
            for (int y = 0; y < len; y++)
            {
                for (int x = 0; x < len; x++)
                    Console.Write(table[y,x] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int GetWinTeams(int[,] table)
        {
            int count = 0;
            int len = Convert.ToInt32(Math.Sqrt(table.Length));

            for (int team = 0; team < len; team++)
            {
                int win = 0, lose = 0;
                for (int enemy = 0; enemy < len; enemy++)
                {
                    if (enemy != team)
                    {
                        if (table[team, enemy] == 3)
                            win++;
                        else if (table[team, enemy] == 0)
                            lose++;
                    }
                }

                if (win > lose)
                    count++;
            }

            return count;
        }
    }
}
