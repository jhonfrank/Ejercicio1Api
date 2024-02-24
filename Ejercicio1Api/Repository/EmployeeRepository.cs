using Ejercicio1Api.Model;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Microsoft.Extensions.Configuration;

namespace Ejercicio1Api.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"SELECT *
                                        FROM Employee
                                        ORDER BY id ASC";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        SqlDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            Employee item = new Employee();
                            item.id = (int) rd["id"];
                            item.name = rd["name"].ToString();
                            item.document_number = rd["document_number"].ToString();
                            item.salary = (decimal) rd["salary"];
                            item.age = (int) rd["age"];
                            item.profile = rd["profile"].ToString();
                            item.admission_date = (DateTime) rd["admission_date"];

                            list.Add(item);
                        }
                        rd.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return list;
        }
        public Employee GetEmployee(int id)
        {
            Employee item = new Employee();
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"SELECT *
                                        FROM Employee
                                        WHERE id = @id
                                        ";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int);
                        command.Parameters["@id"].Value = id;

                        SqlDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            item.id = (int)rd["id"];
                            item.name = rd["name"].ToString();
                            item.document_number = rd["document_number"].ToString();
                            item.salary = (decimal)rd["salary"];
                            item.age = (int)rd["age"];
                            item.profile = rd["profile"].ToString();
                            item.admission_date = (DateTime)rd["admission_date"];
                        }
                        rd.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return item;
        }
        public Employee GetEmployee(string document_number)
        {
            Employee item = new Employee();
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"SELECT *
                                        FROM Employee
                                        WHERE document_number = @document_number
                                        ";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.Add("@document_number", SqlDbType.VarChar);
                        command.Parameters["@document_number"].Value = document_number;

                        SqlDataReader rd = command.ExecuteReader();


                        while (rd.Read())
                        {
                            item.id = (int)rd["id"];
                            item.name = rd["name"].ToString();
                            item.document_number = rd["document_number"].ToString();
                            item.salary = (decimal)rd["salary"];
                            item.age = (int)rd["age"];
                            item.profile = rd["profile"].ToString();
                            item.admission_date = (DateTime)rd["admission_date"];
                        }
                        rd.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return item;
        }
        public void SaveEmployee(Employee item)
        {
            int rows = 0;
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"INSERT INTO Employee
                                        VALUES(@name,@document_number,@salary,@age,@profile,@admission_date)
                                        ";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.Add("@name", SqlDbType.VarChar);
                        command.Parameters["@name"].Value = item.name;

                        command.Parameters.Add("@document_number", SqlDbType.VarChar);
                        command.Parameters["@document_number"].Value = item.document_number;

                        command.Parameters.Add("@salary", SqlDbType.Decimal);
                        command.Parameters["@salary"].Value = item.salary;

                        command.Parameters.Add("@age", SqlDbType.Int);
                        command.Parameters["@age"].Value = item.age;

                        command.Parameters.Add("@profile", SqlDbType.VarChar);
                        command.Parameters["@profile"].Value = item.profile;

                        command.Parameters.Add("@admission_date", SqlDbType.DateTime);
                        command.Parameters["@admission_date"].Value = item.admission_date;

                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void UpdateEmployee(int id, Employee item)
        {
            int rows = 0;
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"UPDATE Employee
                                        SET name = @name,
                                            document_number = @document_number,
                                            salary = @salary,
                                            age = @age,
                                            profile = @profile,
                                            admission_date = @admission_date
                                        WHERE id = @id
                                        ";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int);
                        command.Parameters["@id"].Value = id;

                        command.Parameters.Add("@name", SqlDbType.VarChar);
                        command.Parameters["@name"].Value = item.name;

                        command.Parameters.Add("@document_number", SqlDbType.VarChar);
                        command.Parameters["@document_number"].Value = item.document_number;

                        command.Parameters.Add("@salary", SqlDbType.Decimal);
                        command.Parameters["@salary"].Value = item.salary;

                        command.Parameters.Add("@age", SqlDbType.Int);
                        command.Parameters["@age"].Value = item.age;

                        command.Parameters.Add("@profile", SqlDbType.VarChar);
                        command.Parameters["@profile"].Value = item.profile;

                        command.Parameters.Add("@admission_date", SqlDbType.DateTime);
                        command.Parameters["@admission_date"].Value = item.admission_date;

                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void DeleteEmployee(int id)
        {
            int rows = 0;
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    string commandText = @"DELETE FROM Employee
                                        WHERE ID = @id
                                        ";

                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.VarChar);
                        command.Parameters["@id"].Value = id;

                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private SqlConnection GetConnection()
        {
            var configuration = WebApplication.CreateBuilder().Configuration;

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }        
    }
}
