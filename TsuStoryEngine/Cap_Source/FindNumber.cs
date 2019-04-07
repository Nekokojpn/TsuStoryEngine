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
        string current = "";
        string cbgm,
            cse,
            cmaintext,
            cqs1,
            cqs2,
            ccommand,
            ccmi,
            ccmim,
            ccmo,
            ccmom,
            cvoice,
            cwallpaper,
            cchara;
      void FindNumber(int number)
        {
            try
            {
                int loc1 = REMAINING.IndexOf("StartNumber" + number);
                int loc2 = REMAINING.IndexOf("EndNumber" + number);
                string lo1 = REMAINING.Substring(loc1, loc2-loc1);
                lo1 = lo1.Replace("StartNumber"+number, "");
                lo1 = lo1.Replace("EndNumber", "");
                current = lo1;
                get_load(number);
            }
            catch(Exception)
            {
                //MessageBox.Show("Not found.");
            }
        }
        void get_load(int number)
        {
           



            {
                int bgml1 = current.IndexOf("BGM");
                int bgml2 = current.IndexOf("EndBGM");
                cbgm = current.Substring(bgml1, bgml2 - bgml1);
                cbgm = cbgm.Substring(4);
                BGM_tex.Text = cbgm;
            }
            {
                int bgml1 = current.IndexOf("Voice");
                int bgml2 = current.IndexOf("EndVoice");
                cvoice = current.Substring(bgml1, bgml2 - bgml1);
                cvoice = cvoice.Substring(6);
                Voice_tex.Text = cvoice;
            }
            {
                int bgml1 = current.IndexOf("SE");
                int bgml2 = current.IndexOf("EndSE");
                cse = current.Substring(bgml1, bgml2 - bgml1);
                cse = cse.Substring(3);
                SE_tex.Text = cse;
            }
            {
                int bgml1 = current.IndexOf("QS1");
                int bgml2 = current.IndexOf("EndQS1");
                cqs1 = current.Substring(bgml1, bgml2 - bgml1);
                cqs1 = cqs1.Substring(4);
                QS1_tex.Text = cqs1;
            }
            {
                int bgml1 = current.IndexOf("QS2");
                int bgml2 = current.IndexOf("EndQS2");
                cqs2 = current.Substring(bgml1, bgml2 - bgml1);
                cqs2 = cqs2.Substring(4);
                QS2_tex.Text = cqs2;
            }
            {
                int bgml1 = current.IndexOf("Wallpaper");
                int bgml2 = current.IndexOf("EndWallpaper");
                cwallpaper = current.Substring(bgml1, bgml2 - bgml1);
                cwallpaper = cwallpaper.Substring(10);
                Wallpaper_tex.Text = cwallpaper;
            }
            {
                int bgml1 = current.IndexOf("ChangeMotionIN");
                int bgml2 = current.IndexOf("EndChangeMotionIN");
                ccmi = current.Substring(bgml1, bgml2 - bgml1);
                ccmi = ccmi.Substring(15);
                ChangeMotionIN_tex.Text = ccmi;
            }
            {
                int bgml1 = current.IndexOf("ChangeMotionMIN");
                int bgml2 = current.IndexOf("EndChangeMotionMIN");
                if (bgml1 > -1)
                {
                
                    ccmim = current.Substring(bgml1, bgml2 - bgml1);
                    ccmim = ccmim.Substring(16);
                    IN_millisec_tex.Text = ccmim;
                }
            }
            {
                int bgml1 = current.IndexOf("ChangeMotionOUT");
                int bgml2 = current.IndexOf("EndChangeMotionOUT");
                ccmo = current.Substring(bgml1, bgml2 - bgml1);
                ccmo = ccmo.Substring(16);
                ChangeMotionOUT_tex.Text = ccmo;
            }
            {
                int bgml1 = current.IndexOf("ChangeMotionMOUT");
                int bgml2 = current.IndexOf("EndChangeMotionMOUT");
                if (bgml1 > -1)
                {
                    ccmom = current.Substring(bgml1, bgml2 - bgml1);
                    ccmom = ccmom.Substring(17);
                    IN_millisec_tex.Text = ccmom;
                }
            }
            {
              
                int bgml1 = current.IndexOf("MainText");
                int bgml2 = current.IndexOf("EndMainText");
                cmaintext = current.Substring(bgml1, bgml2 - bgml1);
                cmaintext = cmaintext.Substring(9);
                MainText_tex.Text = cmaintext;
            }
            {
                int bgml1 = current.IndexOf("Command");
                int bgml2 = current.IndexOf("EndCommand");
                ccommand = current.Substring(bgml1, bgml2 - bgml1);
                ccommand = ccommand.Substring(8);
                Command_tex.Text = ccommand;
            }
            {
                int bgml1 = current.IndexOf("CharactorName");
                int bgml2 = current.IndexOf("EndCharactorName");
                cchara = current.Substring(bgml1, bgml2 - bgml1);
                cchara = cchara.Substring(14);
                Charactor_tex.Text = cchara;
            }
        }


        }
}
