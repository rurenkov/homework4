using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {

  

        //static int add = 0;

        //*******************************************************//
        // push method;
        //*******************************************************//
        public static void PUSH(int add, int Stacksize)
        {

            int top = 0;
            int[] array3 = new int[Stacksize];
            if (top != Stacksize)
            {
                array3[top] = add;
                top++;
            }

            Console.WriteLine("[{0}]", string.Join(", ", array3));
            Console.WriteLine(top);
        }


//*******************************************************//
// swap method;
//*******************************************************//
public static void SWAP(ref int a, ref int b)
        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;

        }
        //*******************************************************//
        //parce method;
        //*******************************************************//
        public static void ParceD(ref int d)
            {
             while (!int.TryParse(Console.ReadLine(), out d))
                {
                Console.WriteLine("Try again..");
                 }
            }



        static void Main(string[] args)
        {
            //*******************************************************//
            // BUBLE SORTING
            //*******************************************************//
            Console.WriteLine("************************");
            Console.WriteLine("******buble************");
            int[] array1 = new int[] { 5, 4, 1, 9, 1 };
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            for (int i = 1; i < array1.Length; i++)
            {
                for (int j = 1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[j - 1])
                    {
                        SWAP(ref array1[j - 1], ref array1[j]);
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", array1));

            //*******************************************************//
            // INSERTING SORT
            //*******************************************************//

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

            //*******************************************************//
            // STACKcc
            //*******************************************************//

            /*
             Push – push data on stack
             Pop – pop data from stack
             IsEmpty – is there any data in stack?
             IsFull – is there stack full?
             Peek – get data from stack without pop
              */

            int Stacksize = 0;
            int add = 0;



            Console.WriteLine("Enter the size of an stack");
            ParceD(ref Stacksize);                  // parce size of stack
            int[] array3 = new int[Stacksize];      // define stack
            Console.WriteLine("[{0}]", string.Join(", ", array3));

            Console.WriteLine("Enter what you want to add"); 
            ParceD(ref add);                        //parce value which needs to be added
            Console.WriteLine(add);
            PUSH(add,Stacksize);                    // push parced value and size of stack to push method
 






            Console.ReadLine();
        }
    }
}
