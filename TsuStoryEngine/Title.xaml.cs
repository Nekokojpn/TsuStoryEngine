using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TsuStoryEngine
{
    /// <summary>
    /// Title.xaml の相互作用ロジック
    /// </summary>
    public partial class Title : Page
    {
        public Title()
        {
            InitializeComponent();
        }
        void add(string st)
        {

            lt.Content = st;
        }
        private void Storyboard_Completed(object sender, EventArgs e)
        {
            add("Checking update started...");
            UpdateChk();
        }
        WebClient wc = new WebClient();
        void UpdateChk()
        {
            add("Connecting update server...");
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
            wc.DownloadStringAsync(new Uri("https://paper.dropbox.com/doc/TsuStory-03kSvkyZ7vSa7r4XPOQig"));
        }
        string all = "";
        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            add("Connected to update server");
            add("Processing...");
            all = e.Result;
            int lo1 = all.IndexOf("PlayerVersion");
            int lo2 = all.IndexOf("EndPlayerVersion");
            string plver = all.Substring(lo1, lo2 - lo1);
            plver = plver.Substring(14);

            webversion = int.Parse(plver);
            verchk();
        }
        void verchk()
        {
            if (mainversion < webversion)
            {
                add("A new version is available.");

                int lo1 = all.IndexOf("PlayerURL=www.mediafire.com");
                int lo2 = all.IndexOf("EndPlayerURL");
                string plver = all.Substring(lo1, lo2 - lo1);
                plver = plver.Substring(10);

                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\WebVer.tsu"))
                {
                    sw.Write("http://" + plver);
                }
                up_button.Visibility = Visibility.Visible;
            }
            else
            {
                add("Current version is latest.");
                faout();
            }


           
        }
            void faout()
        {
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
            myG.BeginStoryboard(st);
        }
        

        private void St_Completed(object sender, EventArgs e)
        {
            var nav = this.NavigationService;
            nav.Navigate(new MainMenu());
           
        }

        private void up_button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Resources\MediaUpdater\UpdaterWithMediafire.exe");
            Application.Current.Shutdown();
        }
    }
}
