using MIS_Prog_AppTest;
using MIS_Prog_AppTest.Data;
using MIS_Prog_AppTest.Models;
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

namespace MIS_Prog_AppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string eventsFile = File.ReadAllText("CalendarExport.csv");

            using EventManagerDBContext _db = new EventManagerDBContext();

            InitializeComponent();
            List<string> items = new List<string>();


            for (int j = 0; j < eventsFile.IndexOf('\n'); j++)
            {
                items.Add(eventsFile.Substring(j, eventsFile.IndexOf('\n') - 1));
                j = eventsFile.IndexOf('\n');
            }


            foreach (var item in items)
            {
                string[] words = item.Split(',');
                string eventTitle = words[0];
                string eventLocation = words[1];
                string eventStart = words[2];
                string eventEnd = words[3];
                Event eve = new Event(eventTitle, eventLocation, eventStart, eventEnd);
                _db.Events.Add(eve);
            }
            _db.SaveChanges();

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
