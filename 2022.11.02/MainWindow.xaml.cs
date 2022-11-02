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

namespace _2022._11._02
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

            if (Number_of_players_TextBox.Text == "" || Convert.ToInt32(Number_of_players_TextBox.Text) > 2 || name_TextBox.Text == "")
            {
                MessageBox.Show("Error");

            }
            else
            {
                Window1 taskWindow = new Window1();
                taskWindow.Show();
            }
        }
    }
}
