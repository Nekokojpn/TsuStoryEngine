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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TsuStoryEngine
{
    /// <summary>
    /// SaveProgress.xaml の相互作用ロジック
    /// </summary>
    public partial class SaveProgress : Window
    {
        public SaveProgress()
        {
            InitializeComponent();
        }

        string REMAIN = "";
        string fil = "";
        int mod = 0;
        DispatcherTimer dt = new DispatcherTimer();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            prg.Value = 5;
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\REMAINING.tsu"))
            {
                REMAIN = sr.ReadToEnd();
            }
            /*
            string name = "";
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
            {
                name = sr.ReadToEnd();
            }
            foreach (string stFilePath in System.IO.Directory.GetFiles(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\", "*"))
            {
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(stFilePath));
            }
            */
            int lo1 = REMAIN.IndexOf("nameof=");
            int lo2 = REMAIN.IndexOf("endnameof");
            string fi = REMAIN.Substring(lo1, lo2 - lo1);
            fi = fi.Substring(7);

            fil = System.IO.Path.GetFileNameWithoutExtension(fi);


            dt.Interval = TimeSpan.FromMilliseconds(500);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            if(mod == 0)
            {
                prg.Value = 40;
                mod = 1;
            }
            else if (mod == 1)
            {
                prg.Value = 60;
                mod = 2;
            }
            else if(mod ==2)
            {
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\" + fil + ".tsu"))
                {
                    sw.Write(REMAIN);
                }
                prg.Value = 100;
                mod = 3;
            }
            else
            {
                this.Close();
            }
        }
    }
}
