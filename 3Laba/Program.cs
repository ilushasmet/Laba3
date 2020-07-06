using System;
using System.Collections.Generic;

namespace _3Laba
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine(new string('-',10) + "Task1" + new string('-',10));
            List<int> list = new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (var item in list)
            {
                int a = item % 2;
                if (a == 0)
                {
                    Console.Write(item + " ");
                }
            }
            foreach (var elem in list)
            {
                int a = elem % 2;
                if (a == 1)
                {
                    Console.Write(elem + " ");
                }
            }
            Console.WriteLine("\n");
            #endregion
            #region Task2

            Console.WriteLine(new string('-', 10) + "Task2" + new string('-', 10));

            int k = 13;
            Dictionary<int, int> numb = new Dictionary<int, int>(k);
            int h = 1;        // Это ключ
            int l = 1;        // Это значение
            int[] arr = new int[k];
            while (h<=k && l<=k)    // Заполнил словарь
            {
                for (int i = 0; i < arr.Length; i++)  // Также заполнил масив значением словаря
                {
                    if (l > 1)
                        break;
                    arr[i] = h;
                    h++;
                    if (h == k + 1)
                        h = 1;
                }
                numb.Add(h, l);
                h++;
                l++;
            }
            Console.WriteLine();
            Console.WriteLine("(\"Key\".\"Value\")");
            Console.WriteLine();
            foreach (KeyValuePair<int, int> keyValue in numb)  // Вывел словарь
            {
                Console.Write( keyValue.Key + "." + keyValue.Value + "  ");
            }
            Console.Write("   -   Dictionary");
            Console.WriteLine( );

            int max = 0;
            int min = 0;
            int o = 0;
            int v = 0;
            for (int i = 1; i < arr.Length; i++)    // Проверка на максимум и минимум
            {
                if (arr[v] > arr[i])  // Минимум
                {
                    min = arr[i];
                    v = i;
                }
                else
                    min = arr[v];

                if (arr[o] > arr[i])  // Максимум
                {
                    max = arr[o];
                    o = i;
                }
                else
                    max = arr[i];
            }

            Console.WriteLine();
            List<int> list1 = new List<int>() { max, min };  // Перенёс "max" и "min" в список 

            foreach (int element1 in list1) // Вывел список
            {
                Console.Write(element1 + " ; ");
            }
            Console.Write("   -   max, min.");
            Console.WriteLine();
            #endregion

        }
    }
}
