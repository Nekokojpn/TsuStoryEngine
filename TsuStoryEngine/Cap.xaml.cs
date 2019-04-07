using Microsoft.Win32;
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
using System.ComponentModel;
using System.IO;

using System.Runtime.InteropServices;

namespace TsuStoryEngine
{
    /// <summary>
    /// Cap.xaml の相互作用ロジック
    /// </summary>
    public partial class Cap : Page
    {
        public Cap()
        {
            InitializeComponent();
        }


        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SetCursorPos(int X, int Y);

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private void MainGri1_Loaded(object sender, RoutedEventArgs e)
        {
            cap_loaded();
        }

       

        private void NEXT_button_Click(object sender, RoutedEventArgs e)
        {
            SaveFase();
        }

        private void number_tex_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(number_tex.Text) > 0)
                {
                    number_loaded();
                }
                else
                {
                    me("Do not set to smaller than 1 at number.", "Error");
                }
                if(voicetext==true)
                {
                        Voice_tex.Items.Add(Selected + "_" + number_tex.Text + ".wav");
                        Voice_tex.Text = Selected + "_" + number_tex.Text + ".wav";
                    
                    
                }
            }
            catch (Exception)
            {

            }
            try
            {
                if (AutoLoad_chk.IsChecked == true)
                {
                    FindNumber(int.Parse(number_tex.Text));
                }
            }
            catch (Exception)

            {

            }
        }

        private void numberback_button_Click(object sender, RoutedEventArgs e)
        {
            number_tex.Text = (int.Parse(number_tex.Text) - 1).ToString();
            
        }

        private void numberforward_button_Click(object sender, RoutedEventArgs e)
        {
            number_tex.Text = (int.Parse(number_tex.Text) + 1).ToString();
            
        }

        private void SHOW_button_Click(object sender, RoutedEventArgs e)
        {
            Save_Temp();
            SaveWindow sw = new SaveWindow();
            sw.Show();
        }

        private void BGMReference_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog bbc = new OpenFileDialog();
            bbc.InitialDirectory = @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\BGM\";
            bbc.FileOk += Bbc_FileOk;
            bbc.ShowDialog();
        }

        private void Bbc_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string opd = ((OpenFileDialog)sender).FileName;
            string opd1 = System.IO.Path.GetFileName(opd);
            try
            {
                System.IO.File.Copy(opd, @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\BGM\" + opd1);
            }
            catch(Exception)
            {
                me("同じファイル名が存在します。同じ名前のファイルを選択します。","");
            }
            
            BGM_tex.Items.Add(opd1);
            BGM_tex.Text = opd1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stw_temp("test!", "notify.tsu");
            NotifyService ns = new NotifyService();
            ns.Show();
            //FindNumber(1);
        }

        private void VoiceReference_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog vbc = new OpenFileDialog();
            vbc.InitialDirectory = @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\vo\";
            vbc.FileOk += Vbc_FileOk;
            vbc.ShowDialog();
        }

        private void Vbc_FileOk(object sender, CancelEventArgs e)
        {
            string opd = ((OpenFileDialog)sender).FileName;
            string opd1 = System.IO.Path.GetFileName(opd);
            try
            { 
            System.IO.File.Copy(opd, @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\vo\" + opd1);
            }
            catch (Exception)
            {
                me("同じファイル名が存在します。同じ名前のファイルを選択します。", "");
            }
            Voice_tex.Items.Add(opd1);
            Voice_tex.Text = opd1;
        }

        private void SEReference_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog sbc = new OpenFileDialog();
            sbc.InitialDirectory = @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\se\";
            sbc.FileOk += Sbc_FileOk;
            sbc.ShowDialog();
        }

        private void Sbc_FileOk(object sender, CancelEventArgs e)
        {
            string opd = ((OpenFileDialog)sender).FileName;
            string opd1 = System.IO.Path.GetFileName(opd);
            try
            { 
            System.IO.File.Copy(opd, @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\se\" + opd1);
            }
            catch (Exception)
            {
                me("同じファイル名が存在します。同じ名前のファイルを選択します。", "");
            }
            SE_tex.Items.Add(opd1);
            SE_tex.Text = opd1;
        }

        private void WallpaperReference_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog wbc = new OpenFileDialog();
            wbc.InitialDirectory = @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\wp\";
            wbc.FileOk += Wbc_FileOk;
            wbc.ShowDialog();
        }

        private void Wbc_FileOk(object sender, CancelEventArgs e)
        {
            string opd = ((OpenFileDialog)sender).FileName;
            string opd1 = System.IO.Path.GetFileName(opd);
            try
            { 
            System.IO.File.Copy(opd, @"C:\Resources\TsuStoryEngine\Titles\" + name + @"\wp\" + opd1);
            }
            catch (Exception)
            {
                me("同じファイル名が存在します。同じ名前のファイルを選択します。", "");
            }
            Wallpaper_tex.Items.Add(opd1);
            Wallpaper_tex.Text = opd1;
        }

        private void SAVE_button_Click(object sender, RoutedEventArgs e)
        {
            int lll = REMAINING.IndexOf("nameof");
            if (lll > -1)
            {
                Save_settings();
                Save_Temp();/*
                savelist.Visibility = Visibility.Visible;
                frame.Navigate(new SavePage());
                CLOSE.Visibility = Visibility.Visible;
                 */
                            /*
                           SaveWindow sw = new SaveWindow();
                           sw.Show();
                          */
                SaveProgress sw = new SaveProgress();
                sw.Show();
            }
            else
            {
                me("Error occured.", "");
               
            }
        }

        private void yukkuri_chk_Checked(object sender, RoutedEventArgs e)
        {
            if(yukkuri_chk.IsChecked==true)
            {
                yukari_chk.IsChecked = false;
                mi("ゆかり録音機能を使用する場合、入力用の専用ソフトとExゆかりソフトが必要です。", "");
            }
            else
            {

            }
        }

        private void BGMMinus_button_Click(object sender, RoutedEventArgs e)
        {
            BGM_tex.Items.RemoveAt(BGM_tex.SelectedIndex);
        }

        private void VoiceMinus_button_Click(object sender, RoutedEventArgs e)
        {
            Voice_tex.Items.RemoveAt(Voice_tex.SelectedIndex);
        }

        private void SEMinus_button_Click(object sender, RoutedEventArgs e)
        {
            SE_tex.Items.RemoveAt(SE_tex.SelectedIndex);
        }

        private void WallpaperMinus_button_Click(object sender, RoutedEventArgs e)
        {
            Wallpaper_tex.Items.RemoveAt(Wallpaper_tex.SelectedIndex);
        }

        private void IsSelected_label_TextInput(object sender, TextCompositionEventArgs e)
        {
            me("", "");
        }

        private void FILES_button_Click(object sender, RoutedEventArgs e)
        {
            FIleSelector fs = new FIleSelector();
            fs.Disposed += Fs_Disposed;
            fs.Show();
        }

        private void Fs_Disposed(object sender, EventArgs e)
        {
            try
            {
                
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\Selected.tsu"))
                {
                    Selected = sr.ReadToEnd();
                }
                
                    IsSelected_label.Content = Selected;
                    NotSelected_label.Visibility = Visibility.Hidden;
                string ss = "";
                
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\titles\"+name+@"\tex\"+Selected))
                {
                    ss = sr.ReadToEnd();

                }
                REMAINING = ss;
            }
            catch(Exception)
            {

            }
        }

        private void CharactorPlus_button_Click(object sender, RoutedEventArgs e)
        {
            if (Charactor_textex.Text != "")
            {
                Charactor_tex.Items.Add(Charactor_textex.Text);
            }
            Charactor_textex.Text = "";
        }

        private void eee_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void currentload_button_Click(object sender, RoutedEventArgs e)
        {
            FindNumber(int.Parse(number_tex.Text));
        }

        private void MainText_tex_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                SaveFase();
            }
           
        }

        private void CLOSE_Click(object sender, RoutedEventArgs e)
        {
            savelist.Visibility = Visibility.Hidden;
        }

        private void yukari_chk_Checked(object sender, RoutedEventArgs e)
        {
            if (yukari_chk.IsChecked == true)
            {
                yukkuri_chk.IsChecked = false;
                mi("When REC YUKKURI voice set to on, File names are fixed automatically. However, this function needs yukari ex software.", "");
            }
            else
            {

            }
        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            clear_currents();
        }

        private void CLb_Click(object sender, RoutedEventArgs e)
        {
            CommandList cll = new CommandList();
            cll.Topmost = true;
            cll.Closed += Cll_Closed;
            cll.Show();
        }

        private void Cll_Closed(object sender, EventArgs e)
        {
            string com = "";
            using (StreamReader sr = new StreamReader("CurrentCommand.tsu"))
            {
                com = sr.ReadToEnd();

            }
            if(Command_tex.Text=="")
            {
                Command_tex.Text = com;
            }
            else
            {
                Command_tex.Text += com;
            }
        }

        private void Copy_maintext_Checked(object sender, RoutedEventArgs e)
        {
            if (Copy_maintext.IsChecked == true)
            {
                mi("When copy maintext set to on, Maintexts are copy when maintext changed. This feature for voiceroid feature.", "");
                copymaintext = true;
            }
            else
            {
                copymaintext = false;
            }
        }

        private void MainText_tex_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(copymaintext==true)
            {
                Clipboard.SetText(MainText_tex.Text);
            }
            pp.ML_c(MainText_tex.Text);
        }

        private void Auto_voice_text_Checked(object sender, RoutedEventArgs e)
        {
            if (Auto_voice_text.IsChecked == true)
            {
                mi("When auto voice text set to on, voice file path is set....", "");
                voicetext = true;
                Voice_tex.Items.Add(Selected + "_" + number_tex.Text + ".wav");
                Voice_tex.Text = Selected + "_" + number_tex.Text + ".wav";
            }
            else
            {
                voicetext = false;
            }
        }

        private void ZUNKO_chk_Checked(object sender, RoutedEventArgs e)
        {
            if (ZUNKO_chk.IsChecked == true)
            {
                mi("When REC ZUNKO voice set to on, File names are fixed automatically. However, this function needs ZUNKO ex software and iclude software. Auto voice text check will be checked when this function use.","");
             
                ZUNKO = true;
            }
            else
            {
                ZUNKO = false;
            }
        }

        private void Charactor_tex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pp.CL_c(Charactor_tex.Text);
        }

        private void Wallpaper_tex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pp.MW_c(Wallpaper_tex.Text);
        }
    }
}
