using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_eg_4
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherQualification { get; set; }
        public string TeacherEmail { get; set; }
        public float TeacherContact { get; set; }
        public List<Student> lststudent { get; set; }
    }
}
