using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class MergeSort
    {
        public static void Sort(char[] tablica, int left = -1, int right = -1)
        {
            int mid;
            if(left == -1 && right == -1)
            {
                left = 0;
                right = tablica.Length - 1;
            }

            if (right > left)
            {
                
                mid = (right + left) / 2;
                Draw(tablica, left, right);
                Sort(tablica, left, mid);
                Sort(tablica, (mid + 1), right);
                Merge(tablica, left, (mid + 1), right);
                Draw(tablica, left, right);
            }

        }

        public static void Merge(char[] tablica, int left,int mid, int right)
        {
            char[] temp = new char[tablica.Length];
            int i, leftEnd, lengthOfInput, tmpPos;

            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfInput = right - left + 1;

            while((left<= leftEnd) && (mid <= right))
            {
                if (tablica[left] <= tablica[mid]) temp[tmpPos++] = tablica[left++];
                else temp[tmpPos++] = tablica[mid++];
            }

            while(left <= leftEnd)
            {
                temp[tmpPos++] = tablica[left++];
            }

            while(mid <= right)
            {
                temp[tmpPos++] = tablica[mid++];
            }

            for (i = 0; i<lengthOfInput; i++)
            {
                tablica[right] = temp[right];
                right--;
            }
        }

        public static void Draw(char[] tablica, int left, int right)
        {
            int mid = (right + left) / 2;
            for (int i = left; i <= mid; i++)
            {
                Console.Write(tablica[i] + " ");
                
            }
            Console.Write("     ");
            for (int i = mid+1; i<= right; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
