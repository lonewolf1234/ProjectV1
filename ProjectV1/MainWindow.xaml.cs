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

namespace ProjectV1
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

        private void Btn_Datapath_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_test.Text = "Create Datapath Selected";

            Window_Datapath window_Datapath = new Window_Datapath();
            window_Datapath.Show();
            
        }

        private void Btn_Component_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_test.Text = "Create Component Selected";

            Window_Component window_Component = new Window_Component();
            window_Component.Show();
        }

        private void Btn_Signal_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_test.Text = "Create Signal Selected";

            Window_Signal window_Signal = new Window_Signal();
            window_Signal.Show();
        }
    }
}
