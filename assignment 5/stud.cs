using System.Collections;
using System;
namespace Stud_det
{
    public class Stdudent
    {
        static void Main()
        {
            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push("Employee");
            stack1.Push(70.2);
            stack1.Push("Durgesh");
            foreach (Object obj in stack1)
            {
                Console.WriteLine("different types of data" + ":" + obj);
            }
            stack1.Pop();
            stack1.Pop();
            foreach (Object obj in stack1)
            {
                Console.WriteLine("after pop operation" + ":" + obj);
            }

            Console.ReadLine();
        }

    }
}