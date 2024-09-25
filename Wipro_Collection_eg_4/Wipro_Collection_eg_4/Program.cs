using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_eg_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> lststudent = new List<Student>();
            Student objStudent = new Student()
            {
                StudentID=101,StudentName="Shankar",StudentContact=12341235134,StudentAddress="Uawdfuyfguwe",StudentEmail="uyldgewdfuiwge"
            };
            lststudent.Add(objStudent);

            Student objStudent2 = new Student()
            {
                StudentID = 102,
                StudentName = "Dattu",
                StudentContact = 4355134,
                StudentAddress = "fuyfguwe",
                StudentEmail = "wdfuiwge"
            };
            lststudent.Add(objStudent);

            Student objStudent3 = new Student()
            {
                StudentID = 102,
                StudentName = "Jai",
                StudentContact = 35134,
                StudentAddress = "U153guwe",
                StudentEmail = "u9788dfuiwge"
                
            };
            lststudent.Add(objStudent);


            List<Teacher> lstteacher = new List<Teacher>();
            Teacher objTeacher = new Teacher()
            {
                TeacherID=201,TeacherName="Meena",TeacherContact=124153,TeacherEmail="uawefgfi",TeacherQualification="UICHUIE",lststudent=lststudent
            };

            Teacher objTeacher1 = new Teacher()
            {
                TeacherID = 201,
                TeacherName = "shiva",
                TeacherContact = 24152343,
                TeacherEmail = "uawefgfi@ewf",
                TeacherQualification = "CHUIEFE",
                lststudent = lststudent
            };



            List<Principal> lstprincipal = new List<Principal>();
            Principal objPrincipal = new Principal()
            {
                PrincipalID=1,PrincipalName="Yugandhar",lststudent=lststudent,lstteacher=lstteacher
            };
            lstprincipal.Add(objPrincipal);




            




        }
    }
}
