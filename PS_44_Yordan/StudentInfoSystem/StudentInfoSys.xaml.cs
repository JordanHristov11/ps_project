using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for StudentInfoSys.xaml
    /// </summary>
    public partial class StudentInfoSys : Window
    {
        StudentInfoContext context = new StudentInfoContext();
        string name;
        public StudentInfoSys()
        {
            InitializeComponent();
            DataContext = new Student();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = false;
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            myPopup.IsOpen = true;
            Student wantedStudent = new Student();
            Student student = new Student();
            student.name = personalFirstName.Text;
            student.secondName = personalMiddleName.Text;
            student.familiyName = personalLastName.Text;
            if (student.name.Length > 0 && student.secondName.Length > 0 && student.familiyName.Length > 0)
            {
                wantedStudent = (from st in context.Students
                                 where student.name.Equals(st.name) && student.secondName.Equals(st.secondName)
                 && student.familiyName.Equals(st.familiyName)
                                 select st).FirstOrDefault();
            }
            else
            {
                return;
            }
            DataContext = wantedStudent;

/*            studentFaculty.Text = wantedStudent.faculty.ToString();
            StudentMajor.Text = wantedStudent.major.ToString();
            StudentOKS.Text = wantedStudent.degree.ToString();
            StudentStatus.Text = wantedStudent.status.ToString();
            StudentFacNum.Text = wantedStudent.facNumber.ToString();
            StudentCourse.Text = wantedStudent.year.ToString();
            StudentPotok.Text = wantedStudent.stream.ToString();
            StudentGroup.Text = wantedStudent.group.ToString();*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = new Student();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
