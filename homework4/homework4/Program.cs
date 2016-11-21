using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        
        // swap method;
        
        public static void SWAP(ref int a, ref int b)
        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;

        }
        static void Main(string[] args)
        {
    
            int[] array1 = new int[]  {5, 4, 1, 9, 1};
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            for (int i=1; i<array1.Length; i++ )
            {
                for (int j = 1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[j-1])
                    {
                        SWAP(ref array1[j-1],ref array1[j]); 
                    }
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("************************");
            Console.WriteLine("******insert************");



            int[] array2 = new int[] { 9, 6, 3, 1, 4 };
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            for (int i = 1; i < array2.Length; i++)
            {
                for (int j = 1; j < array2.Length; j++)
                {
                    if (array2[j] < array2[j - 1])
                    {
                        SWAP(ref array2[j - 1], ref array2[j]);
                        
                        j--;
                 
                    }
                }

            }

            Console.WriteLine("[{0}]", string.Join(", ", array2));





            Console.ReadLine();
        }
    }
}
