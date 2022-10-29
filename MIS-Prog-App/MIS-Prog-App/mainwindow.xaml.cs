using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Window = System.Windows.Window;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            Window adminWin = new Admin();
            adminWin.Show();
            this.Close();
            
        }

        private void StudentButton_Click(object sender, RoutedEventArgs e)
        {
            Window studentWin = new Student();
            studentWin.Show();
            this.Close();
        }
    }
}
