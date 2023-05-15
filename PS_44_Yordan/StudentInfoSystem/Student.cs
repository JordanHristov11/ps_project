using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student : INotifyPropertyChanged
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public string secondName { get; set; }
        public string familiyName { get; set; }
        public string faculty { get; set; }
        public string major { get; set; }
        public string degree { get; set; }
        public StudentStatus? status { get; set; }
        public string facNumber { get; set; }
        public int? year { get; set; }
        public int? stream { get; set; }
        public int? group { get; set; }

        public Student()
        {
            Students = new ObservableCollection<string>();
        }
       /* public string FirstName
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }
        public string SecondName
        {
            get { return secondName; }
            set
            {
                if (secondName != value)
                {
                    secondName = value;
                    OnPropertyChanged("SecondName");
                }
            }
        }
        public string FamiliyName
        {
            get { return familiyName; }
            set
            {
                if (familiyName != value)
                {
                    familiyName = value;
                    OnPropertyChanged("FamiliyName");
                }
            }
        }*/

        public ObservableCollection<string> Students { get; set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        LoginCommand LoginCommand = new LoginCommand();
        public LoginCommand Login
        {
            get { return LoginCommand;}
        }
    }
}
