using MIS_Prog_AppTest.Data;
using MIS_Prog_AppTest.Models;
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

namespace MIS_Prog_AppTest
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit()
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
    }
}
