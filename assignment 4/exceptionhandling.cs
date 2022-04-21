using System;

namespace ExceptionHandling
{
    class User_Excep
    {
        public static void Main()

        {
            Push_pop pp = new Push_pop();

            pp.Push(55);
            pp.Push(25);
            pp.Push(30);
            pp.Push(40);
            pp.Push(50);
            //   pp.Push(60);
            //    pp.Push(70);
            pp.print();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

        }
    }


    public class Push_pop
    {
        int[] arr = new int[5];

        int top = 0;
        public void Push(int data)

        {

            try
            {
                if (top == 5)
                {
                    throw new StackException(" User defined Stack Exception : over flow Exception");
                    return;
                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception)
            {

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                throw new StackException("user Defined Stack Exception : Under flow");
                return 0;
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }

    class StackException : Exception
    {
        public StackException(String message) : base(message)
        {
            Console.WriteLine(message);
        }

    }

}

