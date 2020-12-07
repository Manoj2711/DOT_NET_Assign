using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee.*/

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size Empolyee Array");
            int size = Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[size];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("enter empNo");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter empName");
                string name = Console.ReadLine();

                Console.WriteLine("enter basic salary");
                decimal basic = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("enter deptNo");
                int dep = Convert.ToInt32(Console.ReadLine());


                Employee e = new Employee(no, name, basic, dep);
                emp[i] = e;
            }


            decimal arr = emp[0].Pbasic;
            for (int i = 1; i < emp.Length; i++)
            {
                if (arr < emp[i].Pbasic)
                {
                    arr = emp[i].Pbasic;
                }
            }
            Console.WriteLine("highest salary is : " + arr);

            Console.WriteLine("Enter Employee no to be searched");

            int empNo = Convert.ToInt32(Console.ReadLine());
            foreach (Employee e in emp)
            {
                if (e.PempNo == empNo)
                {
                    Console.WriteLine("Empno :=" + e.PempNo + " name=: " + e.Pname + " emp basic:= " + e.Pbasic + " depNo := " + e.PdeptNo);
                }
            }

            Console.ReadLine();
        }
    }


    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private int deptNo;


        public Employee(int empNo, string name, decimal basic, int depNo)
        {

            this.empNo = empNo;
            this.name = name;
            this.basic = basic;
            this.deptNo = depNo;
        }

        #region property
        public string Pname
        {
            set
            {

                if (value.Length != 0)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }

        public int PempNo
        {
            get
            {
                return empNo;
            }
        }

        public decimal Pbasic
        {
            set
            {
                if (value >= 25000 && value <= 100000)
                {
                    this.basic = value;

                }
                else
                {
                    Console.WriteLine("enter basic between 25000 to 35000");
                }
            }
            get
            {
                return basic;
            }
        }

        public int PdeptNo
        {
            set
            {
                if (value > 0)
                {
                    this.deptNo = value;
                }
                else
                {
                    Console.WriteLine("deptno must be above 0");
                }
            }
            get
            {
                return deptNo;
            }
        }
        #endregion

    }
}