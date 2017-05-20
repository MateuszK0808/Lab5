using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string wybor;
            while (flag) 
            {
                wybor = Utils.DrawMenu();
                Random rand = new Random();
                int[] tablica = new int[10];
                for (int i = 0; i < tablica.Length; i++)
                {
                    tablica[i] = rand.Next(0, 100);
                }
                if (wybor == '1'.ToString()) Bubble.Sort(tablica);
                else if (wybor == '2'.ToString()) Selection.Sort(tablica);
                else if (wybor == '3'.ToString()) Insertion.Sort(tablica);
                else if (wybor == '4'.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Proszę wprowadzić tekst");
                    char[] tekst = Console.ReadLine().ToArray();
                    MergeSort.Sort(tekst);
                    Utils.PrintCharArray(tekst);
                    Console.WriteLine("\n KONIEC!");
                    Console.Read();
                    Utils.DrawMenu();
                }
                else flag = false;
            } 
        }
    }
}
