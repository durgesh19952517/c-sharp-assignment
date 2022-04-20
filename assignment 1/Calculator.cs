using System;

namespace Calculation
{
    class Calculator
    {
        static void Main(string[] args)
        {

            int num1, num2, result;
            int calculate;
           
            Console.Write("Please enter the first no: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second no: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a no between 1 to 4 = ");
            calculate= Convert.ToInt32(Console.ReadLine());

            switch (calculate)
            {

                case 1:
                    result = num1 - num2;
                    Console.Write(result);
                    break;

                case 2:
                    result = num1 + num2;
                    Console.Write(result);
                    break;

                case 3:
                    result = num1 / num2;
                    Console.Write(result);
                    break;

                case 4:
                    result = num1 * num2;
                    Console.Write(result);
                    break;

                default:
                    Console.WriteLine("invalid opertion");
                    break;
            }
            Console.ReadLine();
        }
    }
}
