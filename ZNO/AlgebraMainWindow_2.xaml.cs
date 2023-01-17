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

namespace ZNO
{
    /// <summary>
    /// Interaction logic for AlgebraMainWindow_2.xaml
    /// </summary>
    public partial class AlgebraMainWindow_2 : Window
    {
        public AlgebraMainWindow_2()
        {
            InitializeComponent();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            ChoiceMainWindow main_win = new ChoiceMainWindow();
            this.Visibility = Visibility.Hidden;
            main_win.Show();
        }

        private void Next_Page_Menu_Click(object sender, RoutedEventArgs e)
        {
            AlgebraMainWindow_2 algebra_win = new AlgebraMainWindow_2();
            this.Visibility = Visibility.Hidden;
            algebra_win.Show();
        }
    }
}
