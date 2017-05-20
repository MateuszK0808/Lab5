using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Utils
    {
        public static void Swap(int[] tablica, int id1, int id2)
        {
            int temp = tablica[id1];
            tablica[id1] = tablica[id2];
            tablica[id2] = temp;
        }

        public static void PrintIntArray(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i < tablica.Length - 1) Console.Write(tablica[i] + " ");
                else Console.Write(tablica[i] + "\n");
            }
        }

        public static void PrintCharArray(char[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i < tablica.Length - 1) Console.Write(tablica[i] + " ");
                else Console.Write(tablica[i] + "\n");
            }
        }

        public static string DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("Laboratorium 5\n");
            Console.WriteLine("1) Bubble Sort");
            Console.WriteLine("2) Selection Sort");
            Console.WriteLine("3) Insertion Sort");
            Console.WriteLine("4) Merge Sort");
            string wybor = Console.ReadLine();
            return wybor;
        }
    }
}
