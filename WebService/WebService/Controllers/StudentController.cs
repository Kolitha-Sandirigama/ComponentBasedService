using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Http;
using WebService.DAL;
using WebService.Models;

namespace WebService.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [ActionName("GetStudents")]
        public List<Student> Get()
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