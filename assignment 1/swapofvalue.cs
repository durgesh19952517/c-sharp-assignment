using System;
public class SwapofValue
{
    public static void interchange(ref int num1, ref int num2)
    {
        int temp;

        temp = num1;
        num1 = num2;
        num2 = temp;
    }
    public static void Main()
    {
        int no1, no2;
        Console.Write("Enter a number: ");
        no1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        no2 = int.Parse(Console.ReadLine());
        interchange(ref no1, ref no2);
        Console.WriteLine("after swapping no1 becomes {0}, and no2 becomes : {1}", no1, no2);

        Console.ReadLine();
    }
}