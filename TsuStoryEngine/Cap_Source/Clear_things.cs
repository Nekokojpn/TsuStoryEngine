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

namespace TsuStoryEngine
{
    /// <summary>
    /// Cap.xaml の相互作用ロジック
    /// </summary>
    public partial class Cap : Page
    {
      void clear_currents()
        {
            BGM_tex.Text = "Continue";
            Voice_tex.Text = "";
            SE_tex.Text = "";
            QS1_tex.Text = "";
            QS2_tex.Text = "";
            Wallpaper_tex.Text = "Continue";
            ChangeMotionIN_tex.Text = "";
            ChangeMotionOUT_tex.Text = "";
            Command_tex.Text = "";
            MainText_tex.Text = "";
            IN_millisec_tex.Text = "";
            OUT_millisec_tex.Text = "";
        }
    
    }
}
