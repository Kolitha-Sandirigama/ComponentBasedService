using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.DAL
{
    public class StudentDAOImpl : StudentDAO
    {
        public List<Student> getAllStudentList()
        {
            try
            {
                string connetionString = ConfigurationManager.ConnectionStrings["ListDbConnectionString"].ConnectionString;
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();


                String sql = "SELECT * FROM Students";

                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<Student> studentList = new List<Student>();
                while (dataReader.Read())
                {
                    Student student = new Student(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5));
                    studentList.Add(student);
                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();

                return studentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}