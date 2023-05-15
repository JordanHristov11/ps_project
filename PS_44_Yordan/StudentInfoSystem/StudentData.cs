using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal static class StudentData
    {

        public static List<Student> TestStudents
        {
            get 
            {
                List<Student> list = new List<Student>();   
                Student student1 = new Student();
                student1.name = "Ivan";
                student1.secondName = "Georgiev";
                student1.familiyName = "Petrov";
                student1.faculty = "FKST";
                student1.major = "KSI";
                student1.degree = "Bechelour";
                student1.status = StudentStatus.CERTIFIED;
                student1.facNumber = "1245124512";
                student1.year = 2;
                student1.stream = 10;
                student1.group = 44;

                list.Add(student1);
                Student student2 = new Student();
                student2.name = "Denis";
                student2.secondName = "Stanislavov";
                student2.familiyName = "Gochev";
                student2.faculty = "FKS";
                student2.major = "ITI";
                student2.degree = "Bechelour";
                student2.status = StudentStatus.CERTIFIED;
                student2.facNumber = "124512312";
                student2.year = 1;
                student2.stream = 9;
                student2.group = 46;

                list.Add(student2);
                return list;
            }
            private set { }
        }

        /*private Student makeOneStudent()
        {
            Student student = new Student();
            student.name = "Ivan";
            return student;
        }*/

       /* private static List<Student> _testStudent = new List<Student>();

        private static void ResetTestStudentData()
        {
            if(!_testStudent.Any()) { 
                Student student= new Student();

            }
        }*/
    }
}
