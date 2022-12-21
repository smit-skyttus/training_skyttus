using System.ComponentModel.DataAnnotations;

namespace WebApi.models
{
    public class emplyoyee
    {
        [Key]
        public int EmpId { get; set; }
        public  string Name { get; set; }
        public  string Dept { get; set; }
        public  string Address { get; set; }
    }
}
