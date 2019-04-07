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
namespace TsuStoryEngine
{
    /// <summary>
    /// Cap.xaml の相互作用ロジック
    /// </summary>
    public partial class Cap : Page
    {
        void Save_settings()
        {
            string BGMitems = "";
            string BGMitems_current;
            int count = BGM_tex.Items.Count;
            int cou = 1;
            while (cou < count)
            {
                
                BGMitems_current = BGM_tex.Items[cou].ToString();
                if (BGMitems == "")
                {
                    BGMitems =  BGMitems_current+Environment.NewLine;
                }
                else
                {
                    BGMitems = BGMitems + BGMitems_current + Environment.NewLine;
                }
                cou++;
            }
            stw_current(BGMitems, "BGMitems.tsu");

            string Voiceitems = "";
            string Voiceitems_current;
            int count2 = Voice_tex.Items.Count;
            int cou2 = 1;
            while (cou2 < count2)
            {
               
                Voiceitems_current = Voice_tex.Items[cou2].ToString();
                if (Voiceitems == "")
                {
                    Voiceitems = Voiceitems_current + Environment.NewLine;
                }
                else
                {
                    Voiceitems = Voiceitems + Voiceitems_current + Environment.NewLine;
                }
                cou2++;
            }
            stw_current(Voiceitems, "Voiceitems.tsu");

            string Seitems = "";
            string Seitems_current;
            int count3 = SE_tex.Items.Count;
            int cou3 = 1;
            while (cou3 < count3)
            {
                
                Seitems_current = SE_tex.Items[cou3].ToString();
                if (Seitems == "")
                {
                    Seitems = Seitems_current + Environment.NewLine;
                }
                else
                {
                    Seitems = Seitems + Seitems_current + Environment.NewLine;
                }
                cou3++;
            }
            stw_current(Seitems, "Seitems.tsu");

            string Wallpaperitems = "";
            string Wallpaperitems_current;
            int count4 = Wallpaper_tex.Items.Count;
            int cou4 = 1;
            while (cou4 < count4)
            {
             
                Wallpaperitems_current = Wallpaper_tex.Items[cou4].ToString();
                if (Wallpaperitems == "")
                {
                    Wallpaperitems = Wallpaperitems_current + Environment.NewLine;
                }
                else
                {
                    Wallpaperitems = Wallpaperitems + Wallpaperitems_current + Environment.NewLine;
                }
                cou4++;
            }
            stw_current(Wallpaperitems, "Wallpaperitems.tsu");

            string CNitems = "";
            string CNitems_current;
            int count5 = Charactor_tex.Items.Count;
            int cou5 = 1;
            while (cou5 < count5)
            {

                CNitems_current = Charactor_tex.Items[cou5].ToString();
                if (CNitems == "")
                {
                    CNitems = CNitems_current + Environment.NewLine;
                }
                else
                {
                    CNitems = CNitems + CNitems_current + Environment.NewLine;
                }
                cou5++;
            }
            stw_current(CNitems, "CNitems.tsu");


        }
    }
}
