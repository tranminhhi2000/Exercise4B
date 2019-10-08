using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw4b
{
    class Program
    {
        private static void Setup(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
                for (int c = 0; c < n; c++)
                    arr[d, c] = ' ';
        }
        private static void Print(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                    Console.Write(arr[d, c]);
                Console.WriteLine();
            }
        }
        private static void Print2(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                    Console.Write(arr[d, c] + " ");
                Console.WriteLine();
            }
        }
        public static void DrawW(int n)
        {
            char[,] arr = new char[n * 4, n * 4];
            Setup(arr, n * 4);
            int a = n - 2;
            int b = n - 1;
            for (int i = 0; i < n; i++)
            {
                arr[i, i] = 'w';
                arr[i, n + a - i] = 'w';
                arr[i, n + a + i] = 'w';
                arr[i, n + a + b + b - i] = 'w';
            }
            Print(arr, 4 * n);
        }
        public static void DrawA(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i, n - a] = 'a';
                arr[i, n - 1 + i] = 'a';
                arr[n - 3, n + 1 - i] = 'a';
                a = a + 1;
            }
            Print(arr, n * 2);
        }
        public static void DrawN(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = 'n';
                arr[i, n - 1] = 'n';
                arr[i, i] = 'n';
                arr[i, n - a] = 'n';
            }
            Print(arr, n * 2);
        }
        public static void DrawX(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[i, i] = 'x';
                arr[i, n - 1 - i] = 'x';
            }
            Print2(arr, n * 2);
        }
        public static void DrawPlus(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[i, n - 3] = '+';
                arr[n - 3, i] = '+';
            }
            Print2(arr, n * 2);
        }
        public static void DrawU(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = 'u';
                arr[n - 1, i] = 'u';
                arr[i, n - 1] = 'u';
            }
            Print2(arr, n * 2);
        }
        public static void DrawV(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            int a = n - 2;
            for (int i = 0; i < n; i++)
            {
                arr[i, i] = 'v';
                arr[i, n + a - i] = 'v';
            }
            Print(arr, n * 2);
        }
        public static void DrawSquare(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            for (int d = 0; d < n; d++)
                for (int c = 0; c < n; c++)
                    arr[d, c] = 'o';
            Print2(arr, n * 2);
        }
        public static void DrawSquare2(int n)
        {
            char[,] arr = new char[n, n];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = 'o';
                arr[0, i] = 'o';
                arr[i, n - 1] = 'o';
                arr[n - 1, i] = 'o';
            }

            Print2(arr, n);
        }
        public static void DrawTriangle(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[i, n - 1 - i] = 'A';
                arr[i, n - 1 + i] = 'A';
                arr[n - 1, i] = 'A';
                arr[n - 1, i + n - 1] = 'A';
            }
            Print(arr, n * 2);
        }
        public static void DrawTriangle2(int n)
        {
            char[,] arr = new char[n * 2, n * 2];
            Setup(arr, n * 2);
            for (int i = 0; i < n; i++)
            {
                arr[0, i] = 'v';
                arr[0, i + n - 1] = 'v';
                arr[i, i] = 'v';
                arr[i, 2 * n - 2 - i] = 'v';
            }
            Print(arr, n * 2);
        }
        public static void Main(String[] args)
        {
            //DrawW(10);
            //DrawA(7);
            DrawN(10);
            // DrawX();
            // DrawPlus(5);
            //DrawU(7);
            // DrawV(7);
            //DrawSquare(5);
            //DrawSquare2(5);
            // DrawTriangle(4);
            //DrawTriangle2(4);
        }
    }
}
