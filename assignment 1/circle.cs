using System;

namespace CircleProgram
{
    class Circle
    {
        static void Area_Circumference()
        {
            double r, a, circumference;    //r=radius,a=area
            const double pi = 3.14;
            Console.Write("Enter radius of circle ");
            r = Convert.ToDouble(Console.ReadLine());

            circumference = 2 * pi * r;     //r=radius
            Console.WriteLine("Circumference of Circle : {0}", circumference);

            a = pi * r * r;    //r=radius,a=area
            Console.WriteLine("\nThe area of circle is : {0}", a);
            Console.ReadLine();

        }

        static void Main(String[] args)
        {
            Circle.Area_Circumference();
        }
    }
}