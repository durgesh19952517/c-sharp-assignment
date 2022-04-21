using System;

namespace project
{
    class Employee
    {
        int Emp_No;
        string Emp_Name;
        double Salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;
        public Employee()
        {
            Console.WriteLine("Enter The emp id:");
            Emp_No = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter the Emp Name :  ");
            Emp_Name = Console.ReadLine();

            Console.WriteLine("Enter the Emp Salary :  ");
            Salary = (Convert.ToInt32(Console.ReadLine()));
        }
        public int empNo
        {
            get { return Emp_No; }
            set { Emp_No = value; }
        }
        public string empName
        { get { return Emp_Name; } }
        public double salary { get { return Salary; } set { Salary = value; } }

        public double Grosssalary()
        {
            if (Salary < 5000)
            {
                HRA = ((salary / 100) * 10);
                TA = ((salary / 100) * 5);
                DA = ((salary / 100) * 15);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 10000)
            {
                HRA = ((salary / 100) * 15);
                TA = ((salary / 100) * 10);
                DA = ((salary / 100) * 20);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 15000)
            {
                HRA = ((salary / 100) * 20);
                TA = ((salary / 100) * 15);
                DA = ((salary / 100) * 25);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 20000)
            {
                HRA = ((salary / 100) * 25);
                TA = ((salary / 100) * 20);
                DA = ((salary / 100) * 30);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary >= 20000)
            {
                HRA = ((salary / 100) * 30);
                TA = ((salary / 100) * 25);
                DA = ((salary / 100) * 35);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            return GrossSalary;
        }
        public void CalculateSalary()
        {
            PF = (GrossSalary / 100) * 10;
            TDS = (GrossSalary / 100) * 18;
            NetSalary = (GrossSalary - (PF + TDS));
        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + Emp_No + "\n" + "EmpName: " + Emp_Name + " \n" + "EmpSal: " + salary + "\n" + "HRA: " + HRA + "\n" + "TA: " + TA + "\n" + "DA: " + DA + "\n" + "PF: " + PF + "\n" + "TDS: " + TDS + "\n" + "NETSALARY: " + NetSalary + "\n" + "GROSS SALARY: " + GrossSalary);
        }
        class EmployeeTest
        {
            static void Main()
            {
                Employee Obj = new Employee();
                Obj.Grosssalary();
                Obj.CalculateSalary();
                Obj.displayEmployeeDetails();
                Console.ReadKey();
            }
        }
    }
}
