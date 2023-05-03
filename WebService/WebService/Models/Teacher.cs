using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public Teacher(int id, string name, string subject, string phoneNumber, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Subject = subject;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

    }
}