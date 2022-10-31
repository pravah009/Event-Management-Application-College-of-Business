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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MIS_Prog_AppTest
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private string first;
        private string last;
        private string em;

        public Registration()
        {
            InitializeComponent();
        }


        private void RegSubmit_Click(object sender, RoutedEventArgs e)
        {
            //using EventManagerDBContext _db = new EventManagerDBContext();
            //Registration[] regs = _db.RSVP.ToArray<Registration>();
            //string first = Convert.ToString(this.RegFN.Text);
            //string last = Convert.ToString(this.RegLN.Text);
            //string em = Convert.ToString(this.RegEmail.Text);
            //Registration regis = new Registration(first, last, em);
            //_db.RSVP.Add(regis);
            //_db.SaveChanges();
        }
    }
}
