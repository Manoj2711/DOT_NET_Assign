using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager();
            Employee e2 = new Manager();
            Employee e3 = new Manager();
            Console.WriteLine(e1.Empno);
            Console.WriteLine(e2.Empno);
            Console.WriteLine(e3.Empno);
            Console.WriteLine("==============================");
            Console.WriteLine(e3.Empno);
            Console.WriteLine(e2.Empno);
            Console.WriteLine(e1.Empno);

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string name;
        private int empNo;
        private short deptNo;
        private decimal basic;
        public static int count = 0;

        public Employee()
        {
            this.Name = "mehul";
            count++;
            this.Empno = count;
            this.Deptno = 0;
            this.basic = 25000;

        }

        public Employee(string name, int empNo, short deptNo, decimal basic)
        {
            count++;
            this.Empno = count;
            this.Name = name;
            this.Empno = empNo;
            this.Deptno = deptNo;
            this.basic = basic;
        }
        public string Name
        {
            set
            {
                if (value == " " || value == null)
                {

                    Console.WriteLine("name cannot be blank");
                }
                else
                {
                    name = value;
                }
            }

            get
            {
                return name;
            }
        }

        public int Empno
        {
            private set
            {

                empNo = value;
            }

            get
            {
                return empNo;
            }
        }

        public short Deptno
        {
            set
            {
                if (value > 0)
                {

                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("plz..enter vlid value");
                }
            }

            get
            {
                return deptNo;
            }
        }

        public abstract void calcNetSalary();
    }

    public class Manager : Employee
    {

        private string designation;


        public Manager()
        {
            this.Designation = designation;
        }
        public Manager(string n, int e, short d, decimal b, string designation) : base(n, e, d, b)
        {
            this.Designation = designation;
        }

        public string Designation
        {
            set
            {
                if (value == " ")
                {
                    Console.WriteLine("can't be empty");
                }
                else
                {
                    designation = value;
                }
            }

            get
            {
                return designation;
            }
        }
        public override void calcNetSalary()
        {
            Console.WriteLine("this is manager netsalary method ");
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;
        public GeneralManager(string n, int e, short d, decimal b, string d1, string perks) : base(n, e, d, b, d1)
        {
            this.perks = perks;
        }

        public override void calcNetSalary()
        {
            Console.WriteLine("this is Generalmanager netsalary method ");
        }

    }

    public class CEO : Employee
    {

        public CEO()
        {

        }
        public sealed override void calcNetSalary()
        {
            Console.WriteLine("this is CEO netsalary method ");
        }
    }
}
