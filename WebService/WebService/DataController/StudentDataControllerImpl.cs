using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.DAL;
using WebService.Models;

namespace WebService.DataController
{
    public class StudentDataControllerImpl: StudentDataController
    {

        public List<Student> GetAllStudentList()
        {
            try
            {
                StudentDAO studentDAO = new StudentDAOImpl();

                return studentDAO.getAllStudentList();
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

    }
}