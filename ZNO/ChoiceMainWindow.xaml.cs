using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace ZNO
{
    /// <summary>
    /// Interaction logic for ChoiceMainWindow.xaml
    /// </summary>
    public partial class ChoiceMainWindow : Window
    {
        public ChoiceMainWindow()
        {
            InitializeComponent();
        }

        private void algebra_button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main_win = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main_win.Show();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
