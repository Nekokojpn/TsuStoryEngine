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
using System.Windows.Threading;

namespace TsuStoryEngine
{
    /// <summary>
    /// ShowTitle.xaml の相互作用ロジック
    /// </summary>
    public partial class ShowTitle : Page
    {
        public ShowTitle()
        {
            InitializeComponent();
        }

        private void STG_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\NameP.tsu"))
            {
                TL.Content = sr.ReadToEnd();
                TL.Opacity = 0;
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\TitleImage.tsu"))
            {
                me.Source = new Uri(sr.ReadToEnd());
            }
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            Storyboard st = new Storyboard();
            DoubleAnimation da = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(2)
            };
            Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
            st.Children.Add(da);
            st.Completed += St_Completed;
            TL.BeginStoryboard(st);
        }

        private void St_Completed(object sender, EventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0,0,2);
            dt.Tick += Dt_Tick;
            dt.Start();
        }
Storyboard st = new Storyboard();
        private void Dt_Tick(object sender, EventArgs e)
        {
            ((DispatcherTimer)sender).Stop();
            
            DoubleAnimation da = new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromSeconds(2)
            };
            Storyboard.SetTargetProperty(da, new PropertyPath("Opacity"));
            st.Children.Add(da);
            st.Completed += St_Completed1;
            STG.BeginStoryboard(st);
        }

        private void St_Completed1(object sender, EventArgs e)
        {
            if (SKIPb.IsEnabled == true)
            {
                var nav = this.NavigationService;
                nav.Navigate(new Cap());
            }
        }

        private void SKIPb_Click(object sender, RoutedEventArgs e)
        {
            st.Stop();
            SKIPb.IsEnabled = false;
            var nav = this.NavigationService;
            nav.Navigate(new Cap());
        }
    }
}
