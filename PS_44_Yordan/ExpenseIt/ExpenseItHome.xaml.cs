using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ExpenseItHome()
        {
            InitializeComponent();
            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                 Name="Mike",
                 Department ="Legal",
                 Expenses = new List<Expense>()
                {
                    new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                    new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }
                },
                 new Person()
                 {
                    Name ="Lisa",
             Department ="Marketing",
             Expenses = new List<Expense>()
                 {
                     new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
                    new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                    }
                  },
                 new Person()
                  {
                    Name="John",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                  {
                    new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
                    new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                    new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                    }
                  },
                  new Person()
                  {
                     Name="Mary",
                     Department ="Finance",
                     Expenses = new List<Expense>()
                 {
                    new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 },
                 new Person()
                 {
                 Name="Theo",
                 Department ="Marketing",
                 Expenses = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 },
                 new Person()
                 {
                 Name="James",
                 Department ="Marketing",
                 Expenses = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 },
                 new Person()
                 {
                 Name="John",
                 Department ="Marketing",
                 Expenses = new List<Expense>()
                 {
                 new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                 }
                 }
             };
            PersonsChecked = new ObservableCollection<string>();

            if(PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
            }
            LastChecked = DateTime.Now;
            MainCaptionText = "View Expense Report";
            this.DataContext = this;

        }
        public ObservableCollection<string> PersonsChecked { get; set; }
        public string MainCaptionText { get; set; }
        public List<Person> ExpenseDataSource { get; set; }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
        private DateTime lastChecked;
        public DateTime LastChecked { get { return lastChecked; }
            set {
            
                lastChecked = value;
            } }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string name = clickedButton.Content.ToString();
            Person personForExpenseReport = (from p in ExpenseDataSource where p.Name == name select p).FirstOrDefault();
            ExpenseReport expenseReport;
            if (personForExpenseReport != null)
            {
                expenseReport = new ExpenseReport(personForExpenseReport);

            }
            else { return; }

            expenseReport.Height = this.Height;
            expenseReport.Width = this.Width;
            expenseReport.Show();
            this.Close();
        }

/*        private void peopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }*/
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            PersonsChecked.Add((peopleListBox.SelectedItem as ExpenseIt.Person).Name);
        }
    }
}
