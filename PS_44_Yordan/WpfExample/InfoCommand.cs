using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand: ICommand
    {
        NamesWindow namesWindow = new NamesWindow();
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
            namesWindow.Show();
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
