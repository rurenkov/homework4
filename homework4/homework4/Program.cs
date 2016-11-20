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
        
        public static void SWAP(int a, int b)
        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;

        }
        static void Main(string[] args)
        {
    
            int[] array1 = new int[]  {5, 4, 1, 3, 9};
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            int tmp = 0;         
            for (int i=1; i<array1.Length; i++ )
            {
                for (int j = 1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[j-1])
                    {
                        //SWAP(array1[j-1], array1[j]); 
                        
                        tmp = array1[j];
                        array1[j] = array1[j - 1];
                        array1[j - 1] = tmp;
                      }
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.ReadLine();
        }
    }
}
