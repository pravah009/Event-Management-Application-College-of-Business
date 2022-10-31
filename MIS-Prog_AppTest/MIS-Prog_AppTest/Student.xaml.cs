using MIS_Prog_AppTest.Data;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MIS_Prog_AppTest.Models;


namespace MIS_Prog_AppTest
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();

            

            using EventManagerDBContext _db = new EventManagerDBContext();

            Event[] eves = _db.Events.ToArray<Event>();

           

            foreach (var eve in eves)
            {
                 Label label = new Label();

                label.Content = eve.ToString();
                label.BorderThickness = new Thickness(5, 5, 5, 5);

                wrappanel.Children.Add(label);
            }



        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

            
        
    }
}
