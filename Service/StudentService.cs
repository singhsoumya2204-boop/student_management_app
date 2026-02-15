using StudentManagementSystemAPI.Models;
using StudentManagementSystemAPI.Data;
using System.Data.SqlClient;

namespace StudentManagementSystemAPI.Services
{
    public class StudentService
    {
        private readonly DbHelper db;

        public StudentService(DbHelper db)
        {
            this.db = db;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> list = new List<Student>();

            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM Students";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Course = reader["Course"].ToString()
                    });
                }
            }
            return list;
        }
    }
}
