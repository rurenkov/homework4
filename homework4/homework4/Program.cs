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
            Console.WriteLine("************************");
            Console.WriteLine("*******stack************");

            /*
             Push – push data on stack
             Pop – pop data from stack
             IsEmpty – is there any data in stack?
             IsFull – is there stack full?
             Peek – get data from stack without pop
              */

            int size = 0;
            Console.WriteLine("Enter the size of an array");
            while ((!int.TryParse(Console.ReadLine(), out size)) || size == 0)
            {
                Console.WriteLine("this is BUKWA or 0");
                Console.WriteLine("Try again..");
            }
            Console.WriteLine("you selected: " + size + " type each element and press enter.");

            int[] array3 = new int[size];
            for (int j = 0; j < size; j++)
            {
                // array1[j] = Convert.ToInt32(Console.ReadLine());
                while ((!Int32.TryParse(Console.ReadLine(), out array3[j])) || array3[j] < 0)
                {
                    Console.WriteLine("Try again..");
                }
            }
            //verify what we have in array
            Console.WriteLine("[{0}]", string.Join(", ", array3));




            Console.ReadLine();
        }
    }
}
