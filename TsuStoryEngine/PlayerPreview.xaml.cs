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

namespace TsuStoryEngine
{
    /// <summary>
    /// PlayerPreview.xaml の相互作用ロジック
    /// </summary>
    public partial class PlayerPreview : Window
    {
        public PlayerPreview()
        {
            InitializeComponent();
        }string name = "";
        void initial()
        {
            
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
            {
                name = sr.ReadToEnd();
            }
        }
       public void MW_c(string fil)
        {
            //MessageBox.Show(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\wp\" + name);
            MW.Source = new Uri(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\wp\" + fil);
        }
       public void CL_c(string name)
        {
            CL.Content = name;

        }
      public void ML_c(string name)
        {
            ML.Content = name;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            initial();
        }
    }
}
