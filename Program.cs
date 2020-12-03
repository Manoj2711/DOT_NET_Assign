using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Manager();
            //Employee e2 = new Manager();
            //Employee e3 = new Manager();
            //Console.WriteLine(e1.Empno);
            //Console.WriteLine(e2.Empno);
            //Console.WriteLine(e3.Empno);
            //Console.WriteLine("==============================");
            //Console.WriteLine(e3.Empno);
            //Console.WriteLine(e2.Empno);
            //Console.WriteLine(e1.Empno);


            //e1.calcNetSalary();

            CEO e4 = new CEO();
            e4.calcNetSalary();
            e4.insert();
            e4.update();
            e4.delete();


            GeneralManager e5 = new GeneralManager();
            e5.calcNetSalary();
            e5.insert();
            e5.update();
            e5.delete();



            //Employee e5 = new GeneralManager();
            //e5.calcNetSalary();




            Console.ReadLine();



        }
    }

    public interface IDBfunction
    {
        void insert();
        void update();
        void delete();


    }

    public abstract class Employee:IDBfunction
    {

        private string name;
        private int empNo;
        private short DeptNo;
        public decimal basic;
        public abstract decimal BASIC
        {
            get;
            set;
        }
        public static int count = 0;


        public Employee()
        {
            count++;
            this.Name = "Manoj";
            this.Empno = count;
            this.DEPTNO = 10;
            this.basic = 4500;


        }

        public Employee(string name, int empNo, short DeptNo, decimal basic)
        {
            count++;
            this.Name = name;
            this.Empno = count;
            this.DEPTNO = DeptNo;
            this.basic = basic;

        }



        public String Name
        {

            set
            {
                if (value == " " || value == null)
                {

                    Console.WriteLine("name cannot be null");

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

        public short DEPTNO
        {

            set
            {
                if (value > 0)
                {
                    DeptNo = value;

                }
                else
                {
                    Console.WriteLine("Enter DEPTNo greater than zero");
                }

            }
            get
            {

                return DeptNo;
            }
        }

        public abstract void calcNetSalary();


        public void delete()
        {
            Console.WriteLine("EMP delete method.....");
        }

        public void insert()
        {
            Console.WriteLine("EMP insert method.....");
        }

        public void update()
        {
            Console.WriteLine("EMP update method.....");
        }

    }


    public class Manager : Employee,IDBfunction
    {

        private string designation;

        public override decimal BASIC
        {
            set
            {
                if (value > 2000)
                {
                    basic = value;

                }
                else 
                {
                    Console.WriteLine("Basic shoud be greater than 2000");
                
                }
            
            }
            get
            {
                return basic;
            
            }

        }

        public Manager()
        {

            this.Designation = "MANAGER";
        }

        public Manager(string n, int eNo, short DNo, decimal b, string designation) : base(n, eNo, DNo, b)
        {
            this.Designation = designation;
        }

        public string Designation
        {

            set
            {
                if (value == " ")
                {
                    Console.WriteLine("Can't empty ");

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
            Console.WriteLine("this is Manager netsalary method ");
        }

        public new void insert()
        {
            Console.WriteLine("Manager insert method..");
        }

        public new void update()
        {
            Console.WriteLine("Manager update method..");
        }

        public new void delete()
        {
            Console.WriteLine("Manager delete method..");
        }
    }


    public class GeneralManager : Manager,IDBfunction
    {  

        private string Perks;

        public override decimal BASIC
        {
            set
            {
                if (value > 2000)
                {
                    basic = value;

                }
                else
                {
                    Console.WriteLine("Basic shoud be greater than 2000");

                }

            }
            get
            {
                return basic;

            }



        }

        public GeneralManager()
        {

            this.Perks = "XYZ";
        }

        public GeneralManager(string n, int eNo, short DNo, decimal b, string des, string Perks) : base(n, eNo, DNo, b, des)
        {
            this.Perks = Perks;
        }



        public override void calcNetSalary()
        {
            Console.WriteLine("this is Generalmanager netsalary method ");
        }


        public new void delete()
        {
            Console.WriteLine("GE delete method.....");
        }

        public new void insert()
        {
            Console.WriteLine("GE insert method.....");
        }

        public new void update()
        {
            Console.WriteLine("GE update method.....");
        }


    }

    public class CEO : Employee,IDBfunction
    {

        public override decimal BASIC
        {
            set
            {
                if (value > 2000)
                {
                    basic = value;

                }
                else
                {
                    Console.WriteLine("Basic shoud be greater than 2000");

                }

            }
            get
            {
                return basic;

            }

        }


        public sealed override void calcNetSalary()
        {
            Console.WriteLine("this is CEO netsalary method ");
        }

        public new void delete()
        {
            Console.WriteLine("CEO delete method.....");
        }

        public new void insert()
        {
            Console.WriteLine("CEO insert method.....");
        }

        public new void update()
        {
            Console.WriteLine("CEO update method.....");
        }
    }


}
