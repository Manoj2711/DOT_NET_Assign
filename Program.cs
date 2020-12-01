using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");


            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);

            Console.WriteLine();

            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);

         //   Console.WriteLine(o3.GetNetSalary());
         //   Employee o4 = new Employee();
         //   o4.NAME = null;



            Console.ReadLine();

        }
    }

    class Employee
    {
        private string Name;
        private int EmpNo;
        private decimal Basic;
        private short DeptNo;
        private static int cnt;
        public Employee(string Name = null, decimal Basic = 0, short DeptNo = 0)
        {



            EmpNo = ++cnt;
            if (Name != null)
                this.Name = Name;
            else
                Console.WriteLine("Name is Null");
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public string NAME
        {
            set
            {
                if (value != null)
                    Name = value;
                else
                    Console.WriteLine("Name cannot be null!.....");
            }
            get
            {
                return Name;
            }
        }

        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }

        public decimal BASIC
        {
            set
            {
                if (value > 0 && value <= 250000)
                    Basic = value;
                else
                    Console.WriteLine("Basic Sal is not in Range ");
            }
            get
            {
                return Basic;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    DeptNo = value;
                else
                    Console.WriteLine("Invalid DeptNo");
            }
        }

        public decimal GetNetSalary()
        {
            return Basic + 2000;
        }
    }

}
