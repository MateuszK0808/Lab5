using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Selection
    {
        public static void Sort(int[] tablica)
        {
            int l = tablica.Length;

            for (int i = 0; i < l; i++)
            {
                int j = i;
                int maxIndex = j;
                for (j = i; j < l; j++)
                {
                    if (tablica[j] > tablica[maxIndex]) maxIndex = j;
                }
                Draw(tablica, i, maxIndex);
                if (maxIndex != i) Utils.Swap(tablica, i, maxIndex);
                
            }
            Console.Clear();
            Console.WriteLine("Selection Sort\n\n\n");
            Utils.PrintIntArray(tablica);
            Console.WriteLine("\nKONIEC");
            Console.Read();
            Utils.DrawMenu();
        }
        public static void Draw(int[] tablica, int index, int maxIndex)
        {
            int l = tablica.Length;
            Console.Clear();
            Console.WriteLine("Selection Sort\n");
            for (int i = 0; i < l; i++)
            {
                if (i < index || i == maxIndex) Console.Write("   ");
                else Console.Write(tablica[i] + " ");
            }

            Console.Write("\n");
            for (int i = 0; i < l; i++)
            {
                if (i == maxIndex) Console.Write(tablica[i] + " ");
                else Console.Write("   ");
            }
            Console.Write("\n");
            for (int i = 0; i < l; i++)
            {
                if (i < index) Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();        
        }
    }
}
