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
using System.Windows.Automation.Peers;
using UIA;
using System.IO;

namespace TsuStoryEngine
{
    /// <summary>
    /// Cap.xaml の相互作用ロジック
    /// </summary>
    public partial class Cap : Page
    {

        //フィールド・変数
        string REMAINING="";


        //ファイル選択？
        string Selected;


        string name,
            namep,
            titleimage;






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
            Main;


        bool copymaintext = false;
        bool voicetext = false;
        bool ZUNKO = false;










        void me(string tex, string title)
        {
            MessageBox.Show(tex, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        void mi(string tex, string title)
        {
            MessageBox.Show(tex, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        void stw_current(string contents,string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_image(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name+ @"\im\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_bgm(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\BGM\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_wallpaper(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\wp\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_se(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\se\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_voice(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\voice\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_tex(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + namep + @"\tex\" + filename))
            {
                sw.Write(contents);
            }
        }
        void stw_temp(string contents, string filename)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\"+filename))
            {
                sw.Write(contents);
            }
        }


    }
}
