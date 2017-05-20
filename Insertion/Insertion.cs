using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Insertion
    {
        public static void Sort(int[] tablica)
        {
            int l = tablica.Length;
            for(int i =0; i< l; i++)
            {
                int j = i;
                while ((j>0)&& (tablica[j] > tablica[j - 1]))
                {
                    int k = j - 1;
                    
                    Utils.Swap(tablica, k, j);
                    j--;
                }

                Draw(tablica, i);
            }
            Console.Clear();
            Console.WriteLine("Insertion Sort\n\n\n");
            Utils.PrintIntArray(tablica);
            Console.WriteLine("\nKONIEC");
            Console.Read();
            Utils.DrawMenu();
        }

        public static void Draw(int[] tablica, int index1)
        {
            int l = tablica.Length;
            Console.Clear();
            Console.WriteLine("Insertion Sort\n");
            for (int i = 0; i < l; i++)
            {
                if (i <= index1+1) Console.Write("   ");
                else Console.Write(tablica[i] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < l; i++)
            {
                if (i == index1+1) Console.Write(tablica[i] + " ");
                else Console.Write("   ");
            }
            Console.Write("\n");
            for (int i = 0; i < l; i++)
            {
                
                if (i <= index1) Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
