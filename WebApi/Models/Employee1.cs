using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Employee1
    {
        [Key]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Adress { get; set; }
    }
}
