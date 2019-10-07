using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise4b
{
    public class Program2
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];
            //InputValue(array);
            Console.WriteLine();
            Drawing.drawU(20);
            //Drawing.drawW(12);
            Console.ReadKey();


        }
        public static void InputValue(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.WriteLine("A[{0}] = ", i);
                String str = Console.ReadLine();
                iArr[i] = int.Parse(str);
            }
        }
        public static bool IsContrain5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    return true;
            }
            return false;
        }
        public static bool IsContrain5or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsContrain5and6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 5 && arr[j] == 6)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int count5(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    c++;
            }
            return c;
        }
        public static int count5or6(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    c++;
            }
            return c;
        }
        public static int Sum(int[] arr)
        {
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum = Sum + arr[i];
            }
            return Sum;
        }

    }
}
