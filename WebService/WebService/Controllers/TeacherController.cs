using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Http;
using WebService.DataController;
using WebService.Models;

namespace WebService.Controllers
{
    public class TeacherController : ApiController
    {
        [HttpGet]
        [ActionName("GetTeachers")]
        public List<Teacher> Get()
        {
            try
            {
                TeacherDataController teacherDataController = new TeacherDataControllerImpl();

                return teacherDataController.GetAllStudentList();

            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}