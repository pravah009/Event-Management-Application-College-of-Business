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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;


namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class StuReg : Window
    {
        private string first;
        private string last;
        private string em;

        public StuReg()
        {
            InitializeComponent();
        }

        private void RegSubmit_Click_1(object sender, RoutedEventArgs e)
        {
            using ProgAppContext _db = new ProgAppContext();
            Registration[] regs = _db.Registrations.ToArray<Registration>();
            string firstN = Convert.ToString(this.RegFN.Text);
            string lastN = Convert.ToString(this.RegLN.Text);
            string eM = Convert.ToString(this.RegEmail.Text);
            int id = displayLB
            Registration regis = new Registration(firstN, lastN, eM, id);
            _db.Registrations.Add(regis);
            _db.SaveChanges();

            RegFN.Clear();
            RegLN.Clear();
            RegEmail.Clear();

            MessageBox.Show("Success!");
        }
    }
}
