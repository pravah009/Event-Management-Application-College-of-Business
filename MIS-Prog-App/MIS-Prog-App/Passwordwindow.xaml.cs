using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Passwordwindow.xaml
    /// </summary>
    public partial class Passwordwindow : Window
    {
        public Passwordwindow()
        {

            InitializeComponent();

            pwdBox.Focus();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
            if (pwdBox.Password == "mis2022")
            {
                Window adminWin = new Admin();
                adminWin.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
