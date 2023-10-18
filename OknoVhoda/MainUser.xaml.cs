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

namespace OknoVhoda
{
    /// <summary>
    /// Логика взаимодействия для MainUser.xaml
    /// </summary>
    public partial class MainUser : Window
    {
        public MainUser()
        {
            InitializeComponent();

        }

        private void exitClick(object sender, RoutedEventArgs e)
        {

            MainWindow exit = new MainWindow();
            exit.Show();
            this.Close();
        }
    }
}
