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

namespace Kita2508_Q5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControlEditable.Visibility = Visibility.Hidden;
            UserControlCustom.Visibility = Visibility.Hidden;
            UserControlReadOnly.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserControlReadOnly.Visibility = Visibility.Hidden;
            UserControlCustom.Visibility = Visibility.Hidden;
            UserControlEditable.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserControlReadOnly.Visibility = Visibility.Hidden;
            UserControlEditable.Visibility = Visibility.Hidden;
            UserControlCustom.Visibility = Visibility.Visible;
        }
    }
}
