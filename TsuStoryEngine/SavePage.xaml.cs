using System;
using System.Collections.Generic;
using System.IO;
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

namespace TsuStoryEngine
{
    /// <summary>
    /// SavePage.xaml の相互作用ロジック
    /// </summary>
    public partial class SavePage : Page
    {
        public SavePage()
        {
            InitializeComponent();
        }

        private void SGrid_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\REMAINING.tsu"))
            {
                REMAIN.Text = sr.ReadToEnd();
            }
            string name = "";
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
            {
                name = sr.ReadToEnd();
            }
            foreach (string stFilePath in System.IO.Directory.GetFiles(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\", "*"))
            {
                comboBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(stFilePath));
            }
            int lo1 = REMAIN.Text.IndexOf("nameof=");
            int lo2 = REMAIN.Text.IndexOf("endnameof");
            string fi = REMAIN.Text.Substring(lo1, lo2 - lo1);
            fi = fi.Substring(7);

            comboBox1.Text = System.IO.Path.GetFileNameWithoutExtension(fi);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\" + comboBox1.Text + ".tsu"))
                {
                    sw.Write(REMAIN.Text);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select file name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
