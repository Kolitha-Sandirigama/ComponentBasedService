using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.DAL
{
    public class TeacherDAOImpl : TeacherDAO
    {
        public List<Teacher> GetAllTeacherList() 
        {
            try
            {
                string connetionString = ConfigurationManager.ConnectionStrings["ListDbConnectionString"].ConnectionString;
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();


                String sql = "SELECT * FROM Teachers";

                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                List<Teacher> teacherList = new List<Teacher>();
                while (dataReader.Read())
                {
                    Teacher teacher = new Teacher(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                    teacherList.Add(teacher);
                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();

                return teacherList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}