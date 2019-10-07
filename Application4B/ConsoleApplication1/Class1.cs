using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4b
{

    public class Drawing
    {
        private static void Setup(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                {
                    arr[d, c] = ' ';
                }
            }
        }
        private static void Print(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(" " + arr[d, c]);
                }
            } Console.WriteLine();
        }
        public static void drawU(int n)
        {
            char[,] arr = new char[n, n];
            Setup(arr, n);

            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = 'u';
                arr[i, n - 1] = 'u';
                arr[n - 1, i] = 'u';

            }
            Print(arr, n + 1/2);
        }
        public static void drawW(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, 2 * n);

            for (int i = 0; i < n; i++)
            {
                arr[i, i / 2] = 'W';

                arr[i, n + i / 2] = 'W';

                arr[i, n - 1 - i / 2] = 'W';

                arr[i, n + n - 1 - i / 2] = 'W';
            }
            Print(arr, 2 * n);
        }
    }
}
