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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string AllText = "\n" + TxtBox1.Text + "\n" + TxtBox2.Text +"\n" + TxtBox3.Text + "\n";
            System.Xml.Serialization.XmlSerializer writer =
             new System.Xml.Serialization.XmlSerializer(typeof(string));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, AllText);
            file.Close();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //Back to Main Menu
        {
            WpfApp2 objSecondWindow = new WpfApp2();
            this.Visibility = Visibility.Hidden; //We hide the current window
            objSecondWindow.Show();
        }
        /*
        private void TxtBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
}
