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

namespace IceTask01_ACT1_19012307
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        void buttonTwo(object sender, RoutedEventArgs e)
        {


            MainWindow win1 = new MainWindow();
            win1.TextChanger.Text = textChangeTB.Text;
            win1.Show();
            this.Close();
        }
    }
}
