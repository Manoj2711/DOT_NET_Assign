using MvcApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MvcApp1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        string str = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True";
        SqlConnection cn = new SqlConnection();

        public ActionResult Index()
        {
            List<Employee> lstEmp = new List<Employee>();
            cn.ConnectionString = str;


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstEmp.Add(new Employee { EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (int)dr["DeptNo"] });
            }

            dr.Close();
            cn.Close();
            return View(lstEmp);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            cn.ConnectionString = str;


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees where EmpNo ="+id;
            
            Employee emp = new Employee();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                emp.EmpNo = (int)dr["EmpNo"];
                emp.Name = (string)dr["Name"];
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }

            dr.Close();
            cn.Close();


            return View(emp);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here

                cn.ConnectionString = str;


                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", emp.EmpNo);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.ExecuteNonQuery();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id=0)
        {
            cn.ConnectionString = str;


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees where EmpNo =" + id;

            Employee emp = new Employee();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                emp.EmpNo = (int)dr["EmpNo"];
                emp.Name = (string)dr["Name"];
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }

            dr.Close();
            cn.Close();

            return View(emp);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                cn.ConnectionString = str;


                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employees set Name = @Name,Basic = @Basic,DeptNo = @DeptNo where EmpNo = @EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            cn.ConnectionString = str;


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees where EmpNo =" + id;

            Employee emp = new Employee();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                emp.EmpNo = (int)dr["EmpNo"];
                emp.Name = (string)dr["Name"];
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }

            dr.Close();
            cn.Close();

            return View(emp);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                cn.ConnectionString = str;


                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Employees where EmpNo="+id;
               
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
