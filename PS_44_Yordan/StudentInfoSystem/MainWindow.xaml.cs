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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> StudStatusChoices { get; set; }

        StudentInfoContext context = new StudentInfoContext();

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        public bool TestStudentsIfEmpty()
        {
            IEnumerable<Student> queryStudents = context.Students;
            int countStudents = queryStudents.Count();

            if(countStudents == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void CopyTestStudents()
        {
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();

        }


        public MainWindow()
        {
            this.DataContext = this;
            FillStudStatusChoices();
            InitializeComponent();
            StudentInfoSys studentInfoSys = new StudentInfoSys();
            studentInfoSys.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Student> students = StudentData.TestStudents;
            Student wantedStudent = (from st in students orderby st.familiyName select st).First();
            ___txtBoxName_.Text = wantedStudent.name.ToString();
            txtBoxSecondName.Text = wantedStudent.secondName.ToString();
            txtBoxFamiliyName.Text = wantedStudent.familiyName.ToString();
            txtBoxFaculty.Text = wantedStudent.facNumber.ToString();
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ___txtBoxName_.Text = "";
            txtBoxSecondName.Text = "";
            txtBoxFamiliyName.Text = "";
            txtBoxFaculty.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool isEmpty = TestStudentsIfEmpty();
            if (isEmpty)
            {
                CopyTestStudents();
            }
        }
    }
}
