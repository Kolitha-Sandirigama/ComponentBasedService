using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Models;

namespace WebService.DataController
{
    public interface StudentDataController
    {
        List<Student> GetAllStudentList();
    }
}
