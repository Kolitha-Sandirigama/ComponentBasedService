﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Models;

namespace WebService.DataController
{
    interface TeacherDataController
    {
        List<Teacher> GetAllTeacherList();
    }
}
