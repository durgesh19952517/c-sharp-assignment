using System;
class Marksheet
{
    static void Main(string[] args)
    {
        Console.WriteLine("Marks of students");

        //-------------------------------enter 1st student name-----------------------------------------------
        Console.WriteLine("Enter student name");
        string stud1_name = Console.ReadLine();

        //marks of students in three subjects english hindi maths
        Console.WriteLine("Enter marks of English");
        float english = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Maths");
        float maths = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Hndi");
        float hindi = float.Parse(Console.ReadLine());

        float total_marks_student1 = (english + maths + hindi) / 3;//average of marks

        Console.WriteLine("Average marks of {0} {1}", stud1_name, total_marks_student1);
        Console.WriteLine("----------------------------------------------------------");

        //-------------------------------enter 2nd student name-----------------------------------------------
        Console.WriteLine("Enter student name");
        string stud2_name = Console.ReadLine();

        //marks of students in three subjects english hindi maths
        Console.WriteLine("Enter marks of English");
        english = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Maths");
        maths = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Hndi");
        hindi = float.Parse(Console.ReadLine());

        float total_marks_student2 = (english + maths + hindi) / 3;//average of marks

        Console.WriteLine("Average marks of {0} {1} ", stud2_name, total_marks_student2);
        Console.WriteLine("----------------------------------------------------------");

        //-------------------------------enter 3rd student name-----------------------------------------------
        Console.WriteLine("Enter student name");
        string stud3_name = Console.ReadLine();

        //marks of students in three subjects english hindi maths
        Console.WriteLine("Enter marks of English");
        english = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Maths");
        maths = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Hndi");
        hindi = float.Parse(Console.ReadLine());

        float total_marks_student3 = (english + maths + hindi) / 3;//average of marks

        Console.WriteLine("Average marks of {0} {1} ", stud3_name, total_marks_student3);
        Console.WriteLine("----------------------------------------------------------");

        //-------------------------------enter 4th student name-----------------------------------------------
        Console.WriteLine("Enter student name");
        string stud4_name = Console.ReadLine();

        //marks of students in three subjects english hindi maths
        Console.WriteLine("Enter marks of English");
        english = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Maths");
        maths = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Hndi");
        hindi = float.Parse(Console.ReadLine());

        float total_marks_student4 = (english + maths + hindi) / 3;//average of marks

        Console.WriteLine("Average marks of {0} {1} ", stud4_name, total_marks_student4);
        Console.WriteLine("----------------------------------------------------------");

        //-------------------------------enter 5th student name-----------------------------------------------
        Console.WriteLine("Enter student name");
        string stud5_name = Console.ReadLine();

        //marks of students in three subjects english hindi maths
        Console.WriteLine("Enter marks of English");
        english = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Maths");
        maths = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter marks of Hndi");
        hindi = float.Parse(Console.ReadLine());

        float total_marks_student5 = (english + maths + hindi) / 3;//average of marks

        Console.WriteLine("Average marks of {0} {1} ", stud5_name, total_marks_student5);
        Console.WriteLine("----------------------------------------------------------");

        //find student who has secured highest average marks
        if (total_marks_student1 > total_marks_student2 && total_marks_student1 > total_marks_student3 && total_marks_student1 > total_marks_student4 && total_marks_student1 > total_marks_student5)
        {
            Console.WriteLine("{0} " + " got highest average marks =" + " {1}", stud1_name, total_marks_student1);
        }
        else
         if (total_marks_student2 > total_marks_student3 && total_marks_student2 > total_marks_student4 && total_marks_student2 > total_marks_student5)
        {
            Console.WriteLine("{0}" + " got highest average marks =" + " {1}", stud2_name, total_marks_student2);
        }
        else
         if (total_marks_student3 > total_marks_student4 && total_marks_student3 > total_marks_student5)
        {
            Console.WriteLine("{0}" + " got highest average marks =" + " {1}", stud3_name, total_marks_student3);
        }
        else
         if (total_marks_student4 > total_marks_student5)
        {
            Console.WriteLine("{0}" + " got highest average marks =" + " {1}", stud4_name, total_marks_student4);
        }
        else
        {
            Console.WriteLine("{0}" + " got highest average marks =" + " {1}", stud5_name, total_marks_student5);
        }





        Console.ReadLine();

    }
}