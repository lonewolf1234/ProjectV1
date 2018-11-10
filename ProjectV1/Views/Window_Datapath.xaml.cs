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
using ProjectV1.Models;

namespace ProjectV1.Views
{
    /// <summary>
    /// Interaction logic for Window_Datapath.xaml
    /// </summary>
    public partial class Window_Datapath : Window
    {

        int UID = 2;

        public Window_Datapath()
        {
            InitializeComponent();

            Port port1 = new Port
            {
                ID = 001,
                Name = "clk",
                Direction = "in",
                Bus = false,
                MSB = "0",
                LSB = "0"
            };

            Port port2 = new Port
            {
                ID = 002,
                Name = "datain",
                Direction = "in",
                Bus = true,
                MSB = "7",
                LSB = "0"
            };

            PortDataGrid.Items.Add(port1);
            PortDataGrid.Items.Add(port2);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddPort_Click(object sender, RoutedEventArgs e)
        {
            Port tempPort = new Port
            {
                ID = UID + 1,
                Name = PortName_TB.Text,
                Direction = Direction_CB.Text,
                Bus = (bool)Bus_CB.IsChecked,
                MSB = MSB_TB.Text,
                LSB = LSB_TB.Text
            };

            UID = UID + 1;

            PortDataGrid.Items.Add(tempPort);

            PortName_TB.Text = String.Empty;

        }
    }
}
