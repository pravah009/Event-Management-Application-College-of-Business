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

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AddButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Add();
        }

        private void DeleteButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Delete();
        }

        private void EditButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Edit();
        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
