using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bubble
    {
        public static void Sort(int[] tablica)
        {
            
            int l = tablica.Length;
            do
            {

                for (int i = 0; i < l; i++)
                {
                    if (i + 1 < l && tablica[i] < tablica[i + 1])
                    {
                        Draw(tablica, i);
                        Utils.Swap(tablica, i, i + 1);
                    }
                }
                
                l--;
            } while (l > 1);
            Console.Clear();

            Console.WriteLine("Sortowanie Bombelkowe\n");

            Utils.PrintIntArray(tablica);

            Console.WriteLine("\n KONIEC");
            Console.Read();
            Utils.DrawMenu();
        }



        public static void Draw(int[] tablica, int index)
        {
            int l = tablica.Length;
            Console.Clear();
            Console.WriteLine("Sortowanie Bombelkowe\n");
            for (int i = 0; i < l; i++)
            {
                if (i == index) Console.Write("   ");
                else Console.Write(tablica[i] + " ");

            }
            Console.Write("\n");
            for (int i = 0; i < l; i++)
            {
                if (i == index) Console.Write(tablica[i] + " ");
                else Console.Write("   ");
            }
            Console.ReadLine();
        }
    }
}
