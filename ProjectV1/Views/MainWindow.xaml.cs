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
using ProjectV1.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ProjectV1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main Data Produced by the windows
        /// </summary>
        DataPath Datapath = new DataPath();

        List<Component> components = new List<Component>();

        List<Signal> signals = new List<Signal>();

        public string DebugPath { get; set; }

        ////////////////////////////////////////////////////////////////

        public MainWindow()
        {
            InitializeComponent();

            DebugPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        }

        private void Btn_Datapath_Click(object sender, RoutedEventArgs e)
        {
            TextBlock_test.Text = "Create Datapath Selected";

            Window_Datapath window_Datapath = new Window_Datapath();
            
            if( window_Datapath.ShowDialog()== true)
            {
                var InputJSON = window_Datapath.OutputJSON;
                Datapath = JsonConvert.DeserializeObject<DataPath>(InputJSON);

                Debug.WriteLine(InputJSON);
               
                System.IO.File.WriteAllText(System.IO.Path.Combine(DebugPath,"JSONFile.txt"), InputJSON);
                
            }
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

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            //GenerateCode(Datapath);
            TextBlock_test.Text = "Code Generated";
        }

        #region
        /*
        private void GenerateCode(DataPath Data)
        {
            List<string> port = new List<string>();

            if(Data != null)
            {
                //Library Code
                string[] Libraries_txt =
                {
                "library IEEE;",
                "use IEEE.STD_LOGIC_1164.ALL;",
                "use IEEE.STD_LOGIC_ARITH.ALL;",
                "use IEEE.STD_LOGIC_UNSIGNED.ALL;",
                "",
            };

                //Entity Begin code
                string EntityBegin_txt = $"entity {Data.Name} is";

                //Port Code
                List<string> ports_txt = new List<string>();

                if (Datapath.Ports.Count > 0)
                {

                    foreach (Port p in Datapath.Ports)
                    {
                        string vector = "";

                        if (p.Bus == true)
                        {
                            vector = $"_vector({p.MSB} downto {p.LSB})";
                        }

                        string s = $"\t{p.Name} : {p.Direction} std_logic{vector}";


                        if (Datapath.Ports.First() == p)
                        {
                            ports_txt.Add("\tPort(" + s + ";");
                        }
                        else if (Datapath.Ports.Last() == p)
                        {
                            ports_txt.Add("\t" + s + ");");
                        }
                        else
                        {
                            ports_txt.Add("\t" + s + ";");
                        }
                    }
                }
                else
                {
                    ports_txt.Add("\tPort(\n);");
                }

                //Entity End Code
                string EntityEnd_txt = $"end {Datapath.Name};";

                //Behavioral Begin code
                string BehavioralBegin_txt = $"architecture {Datapath.ArchName} of {Datapath.Name} is";

                string Begin_txt = "\nbegin";

                //Component Code


                //Behavioral End Code
                string BehavioralEnd_txt = $"\nend {Datapath.ArchName};";


                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(DebugPath, "VHDLFile.txt")))

                {
                    outputFile.WriteLine(DebugPath);

                    //libraries
                    foreach (string line in Libraries_txt)
                        outputFile.WriteLine(line);

                    //Entity begin
                    outputFile.WriteLine(EntityBegin_txt);

                    //Ports
                    foreach (string line in ports_txt)
                        outputFile.WriteLine(line);

                    //Entity End
                    outputFile.WriteLine(EntityEnd_txt);
                    outputFile.WriteLine("");

                    //Behaviourial Begin
                    outputFile.WriteLine(BehavioralBegin_txt);
                    outputFile.WriteLine(Begin_txt);
                    outputFile.WriteLine("");
                    outputFile.WriteLine("");

                    //Behaviourial End
                    outputFile.WriteLine(BehavioralEnd_txt);
                }
            }

           
        }
        */
        #endregion
    }
}
