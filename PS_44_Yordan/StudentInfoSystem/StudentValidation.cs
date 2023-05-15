using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(UserLogin.User user)
        {
            if(user.facNum == null)
            {
                Console.WriteLine("There is no Student with that facNum");
                return null;
            }
            Student student = (from s in StudentData.TestStudents where s.facNumber.Equals(user.facNum) select s).First();
            if(student== null)
            {
                Console.WriteLine("There is no Student with that facNum");
                return null;
            }
            return student;

        }
    }
}
