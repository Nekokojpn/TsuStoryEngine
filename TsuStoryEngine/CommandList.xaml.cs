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
using System.IO;
namespace TsuStoryEngine
{
    /// <summary>
    /// CommandList.xaml の相互作用ロジック
    /// </summary>
    public partial class CommandList : Window
    {
        public CommandList()
        {
            InitializeComponent();
        }

        void sw_c(string te)
        {
            using (StreamWriter sw = new StreamWriter("CurrentCommand.tsu"))
            {
                sw.Write(te);
            }
            this.Close();
        }
        void sw(string te)
        {
            using (StreamWriter sw = new StreamWriter("CurrentCommand.tsu"))
            {
                sw.Write(te);
            }
            this.Close();
        }
        private void QS1_Click(object sender, RoutedEventArgs e)
        {
            sw_c("QS1={.tsu}EndQS1;");
        }

        private void QS2_Click(object sender, RoutedEventArgs e)
        {
            sw_c("QS2={.tsu}EndQS2;");
        }

        private void Loadfile_Click(object sender, RoutedEventArgs e)
        {
            sw_c("LoadFile={.tsu}EndLoadFile;");
        }

        private void FOB_Click(object sender, RoutedEventArgs e)
        {
            sw_c("FadeOutBGM;");
        }

        private void SM_Click(object sender, RoutedEventArgs e)
        {
            sw_c("ShowMaintext;");
        }

        private void HM_Click(object sender, RoutedEventArgs e)
        {
            sw_c("HideMaintext;");
        }

        private void ShowTitle_Click(object sender, RoutedEventArgs e)
        {
            sw_c("ShowTitle;");
        }
    }
}
