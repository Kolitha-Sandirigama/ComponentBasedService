using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Models;

namespace WebService.DAL
{
    public interface StudentDAO
    {
        List<Student> getAllStudentList();
    }
}
