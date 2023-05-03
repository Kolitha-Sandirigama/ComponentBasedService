using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.DAL;
using WebService.Models;

namespace WebService.DataController
{
    public class TeacherDataControllerImpl : TeacherDataController
    {
        public List<Teacher> GetAllTeacherList()
        {
            TeacherDAO teacherDAO = new TeacherDAOImpl();
            return teacherDAO.GetAllTeacherList();
        }
    }
}