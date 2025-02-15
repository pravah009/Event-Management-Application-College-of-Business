﻿
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MIS_Prog_App.Models;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public Add()
        {
            InitializeComponent();
        }

        private void AddSubmit_Click(object sender, RoutedEventArgs e)
        {

            
            using ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();
            string eventTitle = Convert.ToString(this.titleTB.Text);
            string eventLocation = Convert.ToString(this.locationTB.Text);
            string eventStart = Convert.ToString(this.eventStartTB.Text);
            string eventEnd = Convert.ToString(this.eventEndTB.Text);
            Event eve = new Event(eventTitle, eventLocation, eventStart, eventEnd);
            _db.Events.Add(eve);
            _db.SaveChanges();

            titleTB.Clear();
            locationTB.Clear();
            eventStartTB.Clear();
            eventEndTB.Clear();

            MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
