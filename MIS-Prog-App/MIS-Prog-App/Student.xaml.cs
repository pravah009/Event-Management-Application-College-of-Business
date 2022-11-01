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



            using ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();



            foreach (var eve in eves)
            {
                
                TextBlock textBlock = new TextBlock();

                textBlock.Text = eve.ToString();
                textBlock.Background = Brushes.LightGray; 

                wrappanel.Children.Add(textBlock);
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
