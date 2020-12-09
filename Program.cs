using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignmentDay8
{
    class Program
    {
        static void Main(string[] args)
        {



            //Q1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest 

            Func<decimal, decimal, decimal, decimal> simpleIntress = (decimal P, decimal N, decimal R) => (P * N * R) / 100;

            Console.WriteLine("Simple Intrest = " + simpleIntress(8, 6, 8));

            Console.WriteLine();

            //Q2. bool IsGreater(int a, int b) -> returns true if a is > b

            Func<int, int, bool> isGreater = (int a, int b) =>
            {
                if (a > b)
                    return true;
                else
                    return false;
            };

            Console.WriteLine("Is Greater = " + isGreater(10, 20));

            Console.WriteLine();

            //Q3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee

            Employee e = new Employee();

            Func<Employee, decimal> getBasic = (Employee e1) => e1.BASIC;

            Console.WriteLine("Basic Salary = " + getBasic(e));

            Console.WriteLine();

            //Q4. bool IsEven(int num) -> returns true if the number is an even number

            Func<int, bool> isEven = (int a) => { return a % 2 == 0; };

            Console.WriteLine("Is Even = " + isEven(10));

            Console.WriteLine();

            //Q5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000

            Func<Employee, bool> IsGreaterThan10000 = (Employee e1) => { return e1.BASIC > 10000; };

            Console.WriteLine("Salary Greater Than 10000 = " + IsGreaterThan10000(e));

            Console.ReadLine();
        }

    }

    public class Employee
    {
        private decimal Basic = 25000;

        public decimal BASIC
        {
            set
            {
                Basic = value;
            }
            get
            {
                return Basic;
            }
        }
    }
}