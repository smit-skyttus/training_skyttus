using Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public Gender gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

    }
}
