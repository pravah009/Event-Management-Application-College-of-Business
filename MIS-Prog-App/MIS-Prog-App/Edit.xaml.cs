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
        public Edit()
        {
            InitializeComponent();

            using ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();



            foreach (var eve in eves)
            {
               
                lstbxEdit.Items.Add(eve);
            }

        }
    }
}
