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

         //*******************************************************//
        // push method;
        //*******************************************************//
        public static void PUSH(ref int add, ref int Stacksize1, ref int top, ref int[] arrayT)
        {

            if (top != Stacksize1)
            {
                arrayT[top] = add;
                top++;
            }
        }
        //*******************************************************//
        // EMPTY stack;
        //*******************************************************//

        public bool IsEmpty(ref int top)
        {

           if (top == 0)
            {
                Console.WriteLine("stack is empty");
                
            }
            return true;
        }
        //*******************************************************//
        // is FULL  stack;
        //*******************************************************//

        public bool IsFull(ref int StackSize, ref int top)
        {

            if (top > StackSize)
            {
                Console.WriteLine("stack is full");
            }
            return true;
        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public static void POPM(ref int top, ref int [] arrayP)
        {

            if (top > 0)
            {
                arrayP[top-1] = 0;
                top--;
            }
          
        }
        //*******************************************************//
        // peek method;
        //*******************************************************//
        public static void PEEK(ref int top, ref int[] arrayP)
        {

            if (top > 0)
            {
                arrayP[top-1]= arrayP[top - 1];
            }

        }
        //*******************************************************//
        // enqueue method;
        //*******************************************************//
        public static void ENQUEUE(ref int put, ref int Buffsize,ref int head, ref int[] buffer)
        {
            if (head<Buffsize)
            {
                buffer[head] = put;
                head++;
            }
            else if (head == Buffsize)
            {
                head = 0;
                buffer[head] = put;
                head++;
            }
        }

        //*******************************************************//
        // DEqueue method;
        //*******************************************************//

        public static void DEQUEUE(ref int tail, ref int Buffsize, ref int[] buffer)

        {
            if (tail < Buffsize)
            {
                buffer[tail] = 0;
                tail++;
            }
        }

        public bool IsFullQ(ref int free)
        {

            if (free <=0)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;
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
            // CIrcular Q
            //*******************************************************//

            
            int Buffsize = 0;
            int put = 0;
            int head = 0;
            int tail = 0;
            
            Console.WriteLine("Enter the size of an stack");
            ParceD(ref Buffsize);                  // parce size of stack
            int[] buffer = new int[Buffsize];      // define stack
            Console.WriteLine("[{0}]", string.Join(", ", buffer));
            int free = Buffsize;


            while (free >= 0)


                    {
                        Console.WriteLine("To add value press :1, to delete value press :2, to exit press: 3 \n");
                        int choise = 0;
                        ParceD(ref choise);
                        switch (choise)
                        {
                         case 1:
                       if (free > 0)
                        {
                            Console.WriteLine("Enter what you want to add \n");
                            ParceD(ref put);                        //parce value which needs to be added

                            ENQUEUE(ref put, ref Buffsize, ref head, ref buffer);
                            Console.WriteLine("[{0}]", string.Join(", ", buffer));
                            free = Buffsize - head;
                            Console.WriteLine("free__" + free);
                        }
                        
                        
                        else if (free == 0)
                        {
                            Console.WriteLine("QUEUE is full. Try to remove one element");
                            Console.WriteLine("[{0}]", string.Join(", ", buffer));
                        }
                        
                        break;

                            case 2:

                                Console.WriteLine("deleting # " + tail);
                                DEQUEUE(ref tail, ref Buffsize, ref buffer);
                                free++;
                                Console.WriteLine("[{0}]", string.Join(", ", buffer));
                                Console.WriteLine("tail__" + tail);
                                break;
                        }
                    
                }
           

            //*********Debug Writes************************************
            /*      
                  PUSH(ref add,ref Stacksize, ref top, ref array3);                    // push parced value and size of stack to push method
                  Console.WriteLine("[{0}]", string.Join(", ", array3));
                  Console.WriteLine(top + " Top after PUSH");

                  POPM(ref top, ref array3);                                           
                  Console.WriteLine(top + " TOP after pop");
                  Console.WriteLine("[{0}]", string.Join(", ", array3));

                  PUSH(ref add, ref Stacksize, ref top, ref array3);                    // push parced value and size of stack to push method
                  Console.WriteLine(top + " Top PUsh after Popp");
                  Console.WriteLine("[{0}]", string.Join(", ", array3));


                  PEEK(ref top, ref array3);
                  Console.WriteLine(top + " Top after peek");
                  Console.WriteLine("[{0}]", string.Join(", ", array3));  
                 */




            Console.ReadLine();
        }
    }
}
