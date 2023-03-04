using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class DatabaseHandler
{
    

    public static SqlConnection GetConnection()
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-MEGS7690;Initial Catalog=master;" +
                "Integrated Security=true;");
        con.Open();
        return con;
    }
    public class EmployeeHandler
    {



        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }


        public static void InsertEmployee1(decimal EMPNO,string ENAME, string job, decimal sal)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("InsertEmployee1", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@Salary", sal);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEmployee(decimal EMPNO, string ENAME, string job, decimal sal)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("UpdateEmployee", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@Salary", sal);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEmployee(decimal EMPNO)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("DeleteEmployee", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllEmployees()
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("GetAllEmployees", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Insert new employee");
                Console.WriteLine("2. Update employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. View all employees");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter employee no: ");
                        decimal EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        string ENAME = Console.ReadLine();
                        Console.Write("Enter employee job: ");
                        string job = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        decimal sal = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.InsertEmployee1(EMPNO,ENAME, job, sal);
                        Console.WriteLine("Employee added successfully");
                        break;

                    case "2":
                        Console.Write("Enter employee no: ");
                        EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        ENAME = Console.ReadLine();
                        Console.Write("Enter employee job: ");
                        job = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        sal = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.UpdateEmployee(EMPNO, ENAME, job, sal);
                        Console.WriteLine("Employee updated successfully");
                        break;

                    case "3":
                        Console.Write("Enter employee no: ");
                        EMPNO = int.Parse(Console.ReadLine());
                        EmployeeHandler.DeleteEmployee(EMPNO);
                        Console.WriteLine("Employee deleted successfully");
                        break;

                    case "4":
                        DataTable employees = EmployeeHandler.GetAllEmployees();
                        foreach (DataRow row in employees.Rows)
                        {
                            Console.WriteLine($"ID: {row["EMPNO"]}, Name: {row["ENAME"]}, Job: {row["job"]}, Salary: {row["Sal"]}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}


