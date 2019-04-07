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
using System.IO;
using System.Windows.Media.Animation;
using Microsoft.Win32;

namespace TsuStoryEngine
{
    /// <summary>
    /// MainMenu.xaml の相互作用ロジック
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Delete(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu");
                File.Delete(@"C:\Resources\TsuStoryEngine\Temp\NameP.tsu");
                File.Delete(@"C:\Resources\TsuStoryEngine\Temp\TitleImage.tsu");
            }
            catch(Exception)
            {

            }
            Wizard wz = new Wizard();
            wz.TopMost = true;
            wz.Disposed += Wz_Disposed;
            wz.Show();
            this.IsEnabled = false;
            
        }
        void me(string tex,string title)
        {
            MessageBox.Show(tex, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        void mi(string tex, string title)
        {
            MessageBox.Show(tex, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Wz_Disposed(object sender, EventArgs e)
        {
            
            this.IsEnabled = true;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
                {

                }
                Storyboard st = new Storyboard();
                DoubleAnimation da = new DoubleAnimation()
                {
                    To = 0,
                    From = 1,
                    Duration = TimeSpan.FromSeconds(1)

                };
                Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
                st.Children.Add(da);
                st.Completed += St_Completed;
                MGU.BeginStoryboard(st);
            }
            catch(Exception)
            {
                me("Canceled.", "Info");
            }
        }

        private void St_Completed(object sender, EventArgs e)
        {
            var nav = this.NavigationService;
            nav.Navigate(new ShowTitle());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            mi("編集したいデータの、Name.tsuを選択してください。", "");
            OpenFileDialog of = new OpenFileDialog();
            of.FileOk += Of_FileOk; 
            of.ShowDialog();
            */
            if (list.SelectedIndex != -1)
            {
                string selecteditem = list.SelectedItem.ToString();
                Of_FileOk(selecteditem);
            }
        }

        private void Of_FileOk(string file)
        {
            string namep;
            using (StreamReader sr = new StreamReader(file))
            {
                namep = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\Name.tsu"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
                {
                    sw.Write(sr.ReadToEnd());
                }
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\NameP.tsu"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Temp\NameP.tsu"))
                {
                    sw.Write(sr.ReadToEnd());
                }
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\TitleImage.tsu"))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Temp\TitleImage.tsu"))
                {
                    sw.Write(sr.ReadToEnd());
                }
            }
            var nav = this.NavigationService;
            nav.Navigate(new ShowTitle());

        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Position = TimeSpan.FromMilliseconds(1);
            ((MediaElement)sender).Play();
        }

        private void MediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            ((MediaElement)sender).Play();
        }

        private void MGU_Loaded(object sender, RoutedEventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"C:\Resources\TsuStoryEngine\Titles\");
            System.IO.FileInfo[] files =
                di.GetFiles("Name.tsu", System.IO.SearchOption.AllDirectories);


            foreach (System.IO.FileInfo f in files)
            {
                list.Items.Add(f.FullName);
            }
        }
    }
}
