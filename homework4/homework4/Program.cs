using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        public static void SWAP(int a, int b)
        {
            int tmp = 0;
                   
               tmp = a;
               a = b;
               b = tmp;
               Console.WriteLine("A= "+a + "  replaced value of A");
               Console.WriteLine("B= "+b + "  replaced value of B");
           }
        static void Main(string[] args)
        {
            
            int size = 5;  
            int[] array1 = new int[]  {5, 4, 1, 3, 9 };
         //   int[] array2 = new int[5];
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            for (int i=1; i<size; i++ )
            {
                for (int j = 1; j < size; j++)
                {
                    if (array1[j] < array1[j-1])
                    {
                        Console.WriteLine(array1[j]);
                        Console.WriteLine(array1[j-1]);
                        SWAP(array1[j], array1[j-1]);
                       
                      Console.WriteLine("[{0}]", string.Join(", ", array1));
                        Console.WriteLine(array1[j]);
                        Console.WriteLine(array1[j - 1]);

                    }
                }
               
            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            
        //    SWAP(6, 5);
        
            Console.ReadLine();
        }
    }
}
