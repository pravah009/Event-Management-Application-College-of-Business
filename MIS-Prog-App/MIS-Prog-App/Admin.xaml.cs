using Microsoft.EntityFrameworkCore.Migrations;
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
using static System.Net.WebRequestMethods;

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
           



            Main.Content = new InitialImage();

        }

        private void AddButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Add();
           
            AddButton1.Background = new SolidColorBrush(Colors.White);
            DeleteButton1.Background = new SolidColorBrush(Colors.Transparent);
            EditButton1.Background = new SolidColorBrush(Colors.Transparent);
            AddButton1.Foreground = new SolidColorBrush(Colors.LightBlue);

        }

        private void DeleteButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Delete();
            DeleteButton1.Background = new SolidColorBrush(Colors.White);
            EditButton1.Background = new SolidColorBrush(Colors.Transparent);
            AddButton1.Background = new SolidColorBrush(Colors.Transparent);
            DeleteButton1.Foreground = new SolidColorBrush(Colors.LightBlue);
        }

        private void EditButton1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Edit();
            EditButton1.Background = new SolidColorBrush(Colors.White);
            DeleteButton1.Background = new SolidColorBrush(Colors.Transparent);
            AddButton1.Background = new SolidColorBrush(Colors.Transparent);
           EditButton1.Foreground = new SolidColorBrush(Colors.LightBlue);
        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
