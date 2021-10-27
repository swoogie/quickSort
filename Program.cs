using System;

namespace qSort
{
    class Program
    {
        private static int indeksas(int[] arr, int l, int h)
        {
            int t;
            int pivot = arr[h]; // pivoto paskyrimas (paskutinis masyvo elementas)
            int i = (l - 1);

            for(int j = l; j <= h -1; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            
            t = arr[i+1];          
            arr[i+1] = arr[h]; // i+1 swappinamas su pivot'u
            arr[h] = t;
            return (i+1);   // grazinamas indeksas skiriantis desine ir kaire puses
        }


        private static void qSort(int[] arr, int l, int h)
        {
            if (l < h)
            {
                int skirstymoIndeksas = indeksas(arr, l, h);
                

                qSort(arr, l, skirstymoIndeksas - 1);   // rekursija sortinama kaire puse
                qSort(arr, skirstymoIndeksas + 1, h);   // rekursija sortinama desine puse
            }
        }


        static void Main(string[] args)
        {
            int n = 9; // elementu skaicius
            int[] arr = new int[] {-12,-55,45,5,6,-49,211,4,2};

            qSort(arr, 0, n-1);

            Console.WriteLine(
                "Surusiuoti skaiciai: ");
            for (int i=0; i<n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}


