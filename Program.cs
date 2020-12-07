using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many student want");
            int size = Convert.ToInt32(Console.ReadLine());


            Student[] s = new Student[size];

            for (int i = 0; i < s.Length; i++)
            {

                Console.WriteLine("Enter Student Rollno ");
                int no = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Student Name ");
                string name = Console.ReadLine();


                Console.WriteLine("Enter Student Marks ");
                decimal mark = Convert.ToInt32(Console.ReadLine());

                Student s1 = new Student(name,no,mark);

                s[i] = s1;

            }

            foreach (Student a in s)
            {
                Console.WriteLine(a.RNO + " " + a.NAME + " " + a.MARKS);
            }



            Console.ReadLine();

        }

    }

    public struct Student
    {
        private string name;
        private int rno;
        private decimal marks;

        public Student(string name, int rno, decimal marks)
        {

            this.name = name;
            this.rno = rno;
            this.marks = marks;
        }

        public string NAME
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

        public int RNO
        {
            set
            {
                if (value > 0)
                {

                    Console.WriteLine("EMP no. can be greater thank 0");
                }
                else
                {
                    rno = value;
                }
            }
            get
            {
                return rno;
            }

        }

        public decimal MARKS
        {
            set
            {
                if (value > 40)
                {

                    Console.WriteLine("MARKS can be greater thank 40");
                }
                else
                {
                    marks = value;
                }
            }
            get
            {
                return marks;
            }

        }





    }
}

