using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        void SaveFase()
        {
            bool suc = false;
            //ここでは空欄とかエラー判定のみIF。
            if(NotSelected_label.Visibility==Visibility.Hidden)
            {
                if (BGM_tex.Text != "")
                {


                    if (QS1_tex.Text != "")
                    {
                        if (QS2_tex.Text != "")
                        {
                            if (Command_tex.Text != "")
                            {
                                if (MainText_tex.Text != "")
                                {
                                    me("If you entered Command area, must be empty Maintext Area.", "Error");
                                }
                                else
                                {
                                    suc = true;
                                    SaveFase_Ready();
                                }
                            }
                            if (MainText_tex.Text != "")
                            {
                                if (Command_tex.Text != "")
                                {
                                    me("If you entered Maintext area, must not be empty Command Area.", "Error");
                                }
                                else
                                {
                                    suc = true;
                                    SaveFase_Ready();
                                }
                            }
                        }
                        else
                        {
                            me("If you entered QSelection1 area, must not be empty QSelection2 Area.", "Error");
                        }
                    }
                    if (QS2_tex.Text != "")
                    {
                        me("If you entered QSelection2 area, must not be empty QSelection1 Area.", "Error");
                    }
                    if (QS1_tex.Text == "")
                    {
                        if (QS2_tex.Text == "")
                        {
                            suc = true;
                            SaveFase_Ready();
                        }
                    }
                }
            }
            if(suc==false)
            {
                me("Error has occured. Retry fix problem later.", "");
            }
        }
        void SaveFase_Ready()
        {
            //BGM
            //Voice
            //SE
            //QSelection1
            //QSelection2
            //Wallpaper
            //ChangeMotion(IN)
            //ChangeMotion(OUT)
            //MainText
            //Command!

            if (yukkuri_chk.IsChecked == true)
            {
                Voice_tex.Items.Add(Selected + "_" + number_tex.Text + ".wav");
                Voice_tex.Text = Selected + "_" + number_tex.Text + ".wav";
                Process.Start(@"softalk\SofTalk.exe", "/R:" + @"C:\Resources\TsuStoryEngine\titles\" + name + @"\vo\"+ Selected+"_"+ number_tex.Text + ".wav /W:" + MainText_tex.Text);
            }

            else if(yukari_chk.IsChecked==true)
            {
                Voice_tex.Items.Add(Selected + "_" + number_tex.Text + "_000.wav");
                Voice_tex.Text = Selected + "_" + number_tex.Text + "_000.wav";
                Process p = new Process();

               
                p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
           
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = false;
                //ウィンドウを表示しないようにする
          //      p.StartInfo.CreateNoWindow = true;
                //コマンドラインを指定（"/c"は実行後閉じるために必要）
               
                p.StartInfo.Arguments = @"/c yukari\yukari_commandline.exe -o C:\Resources\TsuStoryEngine\titles\" + name + @"\vo\"+ Selected+"_"+ number_tex.Text + ".wav "+MainText_tex.Text;

                //起動
                p.Start();

                //出力を読み取る
                string results = p.StandardOutput.ReadToEnd();

                //プロセス終了まで待機する
                //WaitForExitはReadToEndの後である必要がある
                //(親プロセス、子プロセスでブロック防止のため)
                p.WaitForExit();
                p.Close();

              
            }
            else if(ZUNKO_chk.IsChecked==true)
            {
                Voice_tex.Items.Add(Selected + "_" + number_tex.Text + ".wav");
                Voice_tex.Text = Selected + "_" + number_tex.Text + ".wav";
                Clipboard.SetText(MainText_tex.Text);
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(1620, 10);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Windows.Forms.SendKeys.SendWait("{F3}");
            }
            string BGM,
                Voice,
                SE,
                QSelection1,
                QSelection2,
                Wallpaper,
                ChangeMotion_IN,
                ChangeMotion_OUT,
                MainText,
                Command,
                CharactorName,
                Main;

            string ChangeMotion_IN_millisec="";
            string ChangeMotion_OUT_millisec="";

           
            BGM = "BGM=" + BGM_tex.Text + "EndBGM:::::";
            Voice = "Voice=" + Voice_tex.Text + "EndVoice:::::";
            SE = "SE=" + SE_tex.Text + "EndSE:::::";
            QSelection1 = "QS1=" + QS1_tex.Text + "EndQS1:::::";
            QSelection2 = "QS2=" + QS2_tex.Text + "EndQS2:::::";
            Wallpaper = "Wallpaper=" + Wallpaper_tex.Text + "EndWallpaper:::::";
            ChangeMotion_IN = "ChangeMotionIN="+ChangeMotionIN_tex.Text + "EndChangeMotionIN:::::";
            if(IN_millisec_tex.Text!=""||IN_millisec_tex.Text!=" ")
            {
                ChangeMotion_IN_millisec = "ChangeMotionMIN=" + IN_millisec_tex.Text + "EndChangeMotionMIN:::::";
            }
            
            ChangeMotion_OUT = "ChangeMotionOUT=" + ChangeMotionOUT_tex.Text + "EndChangeMotionOUT:::::";
            if (OUT_millisec_tex.Text != "" || OUT_millisec_tex.Text != " ")
            {
                ChangeMotion_OUT_millisec = "ChangeMotionMOUT=" + OUT_millisec_tex.Text + "EndChangeMotionMOUT:::::";
            }
            MainText = "MainText=" + MainText_tex.Text + "EndMainText:::::";
            CharactorName = "CharactorName=" + Charactor_tex.Text + "EndCharactorName";
            Command = "Command=" + Command_tex.Text + "EndCommand:::::";

            Main = "StartNumber" + number_tex.Text + "{" +"\r\n"+ BGM
                + "\r\n" + Voice
                + "\r\n" + SE
                + "\r\n" + QSelection1
                + "\r\n" + QSelection2
                + "\r\n" + Wallpaper
                + "\r\n" + ChangeMotion_IN;
            if (IN_millisec_tex.Text != "" || IN_millisec_tex.Text != " ")
            {
                Main = Main + "\r\n" + ChangeMotion_IN_millisec;
            }
            Main = Main + "\r\n" + ChangeMotion_OUT;

            if (OUT_millisec_tex.Text != "" || OUT_millisec_tex.Text != " ")
            {
                Main = Main + "\r\n" + ChangeMotion_OUT_millisec;
         
            }
                Main= Main+ "\r\n" + MainText
                + "\r\n" + CharactorName
                + "\r\n" + Command
                + "\r\n" + "}EndNumber" + number_tex.Text+Environment.NewLine;
           // me(REMAINING, "");

            if(REMAINING=="")
            {
                
                REMAINING = "nameof="+System.IO.Path.GetFileName(Selected)+"endnameof"+Environment.NewLine+Main;
            }
            else
            {
                string current = "";
                int lo1 = REMAINING.IndexOf("StartNumber" + number_tex.Text);
                string chk = "";
                try
                {
                    chk = REMAINING.Substring(lo1);
                }
                catch (Exception)
                {
               

                }
                int lo2 = -1;
                try
                {
                    //chk = chk.Substring(11);
                    chk = chk.Substring(number_tex.Text.ToString().Length);

                     lo2 = chk.IndexOf("{");
                }
                catch(Exception)
                {

                }
                if (lo2 > -1)
                {
                    current = chk;
                    int ll1 = REMAINING.IndexOf("EndNumber"+number_tex.Text);
                    ll1 = ll1 + 9 + number_tex.Text.Length;
                    //  current=current.Substring()
                    current = REMAINING.Substring(lo1, ll1-lo1);
                    
                    REMAINING = REMAINING.Replace(current, "");
                }
                    if (number_tex.Text.Length == 1)
                {
                    string rep = "nameof=" + System.IO.Path.GetFileName(Selected) + "endnameof";
                    REMAINING = REMAINING.Replace(rep,"");
                    REMAINING =rep+Environment.NewLine+Main + REMAINING + Environment.NewLine;
                }
                else if (number_tex.Text.Length == 2)
                {
                    REMAINING = REMAINING + Environment.NewLine + Main;
                }
            }

            clear_currents();
            number_tex.Text = (int.Parse(number_tex.Text) + 1).ToString();
            MainText_tex.Focus();
        }
    }
}
