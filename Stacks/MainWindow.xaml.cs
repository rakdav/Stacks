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

namespace Stacks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Monitor> _monitors;
        public MainWindow()
        {
            InitializeComponent();
            _monitors = new Stack<Monitor>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();  
            if(addWindow.ShowDialog()==true)
            {
                Monitor monitor = addWindow.MonitorMy;
                _monitors.Push(monitor);
                Monitors.ItemsSource = null;
                Monitors.ItemsSource = _monitors;
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _monitors.Pop();
            Monitors.ItemsSource = null;
            Monitors.ItemsSource = _monitors;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int count = 0;
            foreach(Monitor i in _monitors)
            {
                if(i.Diagonal>20)
                    count++;
            }
            MessageBox.Show(count.ToString());
        }
    }
}
