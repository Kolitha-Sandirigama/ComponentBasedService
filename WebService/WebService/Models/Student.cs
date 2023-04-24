using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Student
    {
        public Student()
        {
        }

        public int studentId { get; set; }                    
        public int rollNo { get; set; }                  
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String branch { get; set; }
        public String college { get; set; }              

        public Student(int studentId, int rollNo, string firstName, string lastName, string branch, string college)
        {
            this.studentId = studentId;
            this.rollNo = rollNo;
            this.firstName = firstName;
            this.lastName = lastName;
            this.branch = branch;
            this.college = college;
        }
    }
}