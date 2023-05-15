using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        { /*//ToDo it need DTO, which is observable
            var student = parameter as Student;
            List<Student> students = StudentData.TestStudents;
            Student wantedStudent = new Student();

            if (student.name.Length > 0 && student.secondName.Length > 0 && student.familiyName.Length > 0)
            {
                wantedStudent = (from st in students
                                 where student.name.Equals(st.name) && student.secondName.Equals(st.secondName)
                 && student.familiyName.Equals(st.familiyName)
                                 select st).FirstOrDefault();
            }
            else
            {
                return;
            }
            student.faculty = wantedStudent.faculty;
            student.major = wantedStudent.major;
            student.degree = wantedStudent.degree;
            student.status = wantedStudent.status;
            student.facNumber = wantedStudent.facNumber;
            student.year = wantedStudent.year;
            student.stream = wantedStudent.stream;
            student.group = wantedStudent.group;*/
        }
    }
}
