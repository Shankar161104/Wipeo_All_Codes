using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_Practice_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> lstTeacher = new List<Teacher>();

            Teacher objTeacher1 = new Teacher();
            objTeacher1.TeacherID = 101;
            objTeacher1.TeacherName = "Saurabh";
            objTeacher1.TeacherEmail = "Jyguyguggu@jbj";
            objTeacher1.TeacherPhone = 1224253f;
            objTeacher1.TeacherAddress = "wefwaegfGWG";
            lstTeacher.Add(objTeacher1);


            Teacher objTeacher2 = new Teacher();
            objTeacher2.TeacherID = 101;
            objTeacher2.TeacherName = "Saurabh";
            objTeacher2.TeacherEmail = "Jyguyguggu@jbj";
            objTeacher2.TeacherPhone = 1224253f;
            objTeacher2.TeacherAddress = "wefwaegfGWG";
           
            lstTeacher.Add(objTeacher2);



            List<Student> lstStudent = new List<Student>();
            Student objStudent1 = new Student()
            {
                StudentID=1,StudentName="Shankar",StudentEmail="shankahashi@idhc",StudentPhone=213435345f,StudentAddress="afarfga"
            };
            lstStudent.Add(objStudent1);

            Student objStudent2 = new Student()
            {
                StudentID = 2,
                StudentName = "Jai",
                StudentEmail = "shankahashi@idhc",
                StudentPhone = 21345f,
                StudentAddress = "varegerag"
            };
            lstStudent.Add(objStudent2);

            foreach(var objstudent in lstTeacher)
            {

            }




        }
    }
}
