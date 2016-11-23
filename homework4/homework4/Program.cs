using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
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

            int choise = 0;
            int Stacksize = 0;
            int top = 0;

            Console.WriteLine("Enter the size of an stack");
            ParceD(ref Stacksize);                  //parce value of size
            Console.WriteLine("SIze of Stack is: " + Stacksize + "\n");
            // creating array
            int[] array3 = new int[Stacksize];
            int NumbOfAdd = 0;
            Console.WriteLine("[{0}]", string.Join(", ", array3));

        
                Console.WriteLine("Push: press 1, Pop: press 2. \n");
                ParceD(ref choise);
            if (choise == 1)
            {
                // for (int i = 0; i < Stacksize; i++)
                //{
                Console.WriteLine("how many values you want to add\n");
                ParceD(ref NumbOfAdd);                         //parce  value

                for (int j = 0; j < NumbOfAdd; j++)
                {
                    Console.WriteLine(" type " + (j) + " element and press enter");
                    ParceD(ref (array3[j]));            //parce value of array element
                    top = j;
                    //int free = Stacksize -
                        }
                Console.WriteLine(" top: " + top);
                Console.WriteLine("[{0}]", string.Join(", ", array3));

            }        
             else
            {
                Console.WriteLine("not implemented");
                               
            }
                    
              

            
             

           
            //Console.WriteLine("POP: press", string.Join(", ", array3));
            
            Console.ReadLine();
        }
    }
}
