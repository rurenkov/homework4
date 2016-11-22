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

                
            int choise = 0;
            int Stacksize= 0;
            
            // if selected 1 , starting to add data to stack

            // making selection of tasks
            Console.WriteLine("Push: press 1, Pop: press 2. \n");
            while (!int.TryParse(Console.ReadLine(), out choise))
            {
                Console.WriteLine("Try again..");
            }
          

            switch (choise)
                {
                 case 1:

                     Console.WriteLine(Stacksize);       //debug write size of array
                        Console.WriteLine("Enter the size of an stack");

                    while ((!int.TryParse(Console.ReadLine(), out Stacksize)) || Stacksize == 0)
                        {
                            Console.WriteLine("Try again..");
                        }
                        Console.WriteLine("SIze of Stack is: " + Stacksize + "\n");
                    int[] array3 = new int[Stacksize];

                    for (int j = 0; j < Stacksize; j++)
                    {
                        Console.WriteLine(" type " + (j) + " element and press enter");
                            while (!int.TryParse(Console.ReadLine(), out array3[j]))
                            {
                                Console.WriteLine("Try again..");
                            }
                        }
                        //verify what we have in array
                        Console.WriteLine("[{0}]", string.Join(", ", array3));
                        break;

                    case 2:


                        Console.WriteLine("stack size is " + Stacksize);       //debug write size of array
                        break;
               
                //verify if empty.




                default:
                    Console.WriteLine("Invalid selection.");
                Console.WriteLine(Stacksize);
                break;
             }

           
            //Console.WriteLine("POP: press", string.Join(", ", array3));

            Console.ReadLine();
        }
    }
}
