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
using Microsoft.Extensions.Logging;
using MIS_Prog_App.Models;


namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();





            ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();



            foreach (var eve in eves)
            {

                lstbxStudent.Items.Add(eve);
            }


        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        public void lstbxStudent_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Gridd.Visibility = System.Windows.Visibility.Visible;


            //Event currentEvent = lstbxStudent
        }

        private void RegSubmit_Click(object sender, RoutedEventArgs e)
        {

            using ProgAppContext _db = new ProgAppContext();
            Registration[] regs = _db.Registrations.ToArray<Registration>();
            string firstN = Convert.ToString(this.RegFN.Text);
            string lastN = Convert.ToString(this.RegLN.Text);
            string eM = Convert.ToString(this.RegEmail.Text);

            Registration regis = new Registration(firstN, lastN, eM);
            Event currentEvent = lstbxStudent.SelectedItem as Event;
            regis.Id = currentEvent.Id;
            _db.Registrations.Add(regis);
            _db.SaveChanges();

            RegFN.Clear();
            RegLN.Clear();
            RegEmail.Clear();

            MessageBox.Show("Success!");

            Gridd.Visibility = System.Windows.Visibility.Hidden;


        }
    }
}