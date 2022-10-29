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
using System.Windows.Shapes;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {


        public List<Event> events;

        public Student()
        {

            InitializeComponent();

            //events = new List<Event>();
            //string[] calendarExp = File.ReadAllLines("CalendarExport.csv");
            //for (int i = 1; i < calendarExp.Length; i++)
            //{
            //    string thatLine = calendarExp[i];
            //    string[] elements = thatLine.Split(",");
            //    Event ev = new Event(elements[0], elements[1], elements[2], elements[3]);
            //    events.Add(ev);
            //}
            //this.EventsListBox.ItemsSource = events;
        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
