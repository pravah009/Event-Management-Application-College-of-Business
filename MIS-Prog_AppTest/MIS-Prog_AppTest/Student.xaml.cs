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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }

        private void BackButton1_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument flowDocument = new FlowDocument();

            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Run("Ernst and Young\n"));
            flowDocument.Blocks.Add(paragraph);

            Paragraph paragraph1 = new Paragraph();
            paragraph.Inlines.Add(new Run("AH3033\n"));
            flowDocument.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph.Inlines.Add(new Run("Start time: 9:30AM\n"));
            flowDocument.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            paragraph.Inlines.Add(new Run("End time: 11:00am\n"));
            flowDocument.Blocks.Add(paragraph3);

            richie.Document = flowDocument;
        }
    }
}
