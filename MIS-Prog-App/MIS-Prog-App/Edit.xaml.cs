using Microsoft.Extensions.Logging;
using MIS_Prog_App.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        Event test = new Event();
        public Edit()
        {
            InitializeComponent();



            ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();



            editListBox.ItemsSource = eves;
        }

        private void editListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            test = (Event)this.editListBox.SelectedItem;

            Gridd2.Visibility = System.Windows.Visibility.Visible;

        }
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            using ProgAppContext _db = new ProgAppContext();

            
                test.EventTitle = editTitle.Text;
                test.EventLocation = editLocation.Text;
                test.EventStart = editStart.Text;
                test.EventEnd = editEnd.Text;
                _db.Update(test);
                _db.SaveChanges();
                editListBox.Items.Refresh();
            
            MessageBox.Show("Success");

            Gridd2.Visibility = System.Windows.Visibility.Hidden;
        }


    }
}
