﻿using Microsoft.Extensions.Logging;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MIS_Prog_App
{
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        public Delete()
        {
            InitializeComponent();

            using ProgAppContext _db = new ProgAppContext();
            Event[] eves = _db.Events.ToArray<Event>();



            //foreach (var eve in eves)
            //{
            //    TextBlock textBlock = new TextBlock();
            //
            //    textBlock.Text = eve.ToString();
            //    textBlock.Background = Brushes.LightGray;
            //    textBlock.Margin = new Thickness(5, 5, 5, 5);
            //
            //    stackpanel.Children.Add(textBlock);
            //}

            deleteListBox.ItemsSource = eves;

        }

        private void deleteListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using ProgAppContext _db = new ProgAppContext();

            if (this.deleteListBox.SelectedIndex != -1)
            {
                Event del = (Event)this.deleteListBox.SelectedItem;
                _db.Events.Remove(del);
                _db.SaveChanges();
                deleteListBox.Items.Refresh();
            }
            MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
