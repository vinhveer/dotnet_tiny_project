using System.ComponentModel;

namespace StudentDB.Models
{
    public class Student
    {
        [DisplayName("ID")]
        public int StudentId { get; set; }

        [DisplayName("Name")]
        public string StudentName { get; set; }

        [DisplayName("Email")]
        public string StudentEmail { get; set; }

        [DisplayName("Address")]
        public string StudentAddress { get; set; }
    }
}