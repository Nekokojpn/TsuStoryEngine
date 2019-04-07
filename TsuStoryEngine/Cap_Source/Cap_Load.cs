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
    {PlayerPreview pp = new PlayerPreview();
       void cap_loaded()
        {

            
            pp.Show();
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
            {
                name = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\NameP.tsu"))
            {
                namep = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\TitleImage.tsu"))
            {
                titleimage = sr.ReadToEnd();
            }
            number_tex.Text = "1";
            TItle_label.Content = name;
            name_label.Content = name;
            namep_label.Content = namep;
            titleimage_label.Content = titleimage;


            //初回起動？？
            bool firstboot = false;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\First.tsu"))
                {
                    firstboot = true;
                }
                
            }
            catch(Exception)
            {
                firstboot = false;
            }
            if (firstboot == true)
            {
                File.Delete(@"C:\Resources\TsuStoryEngine\Temp\First.tsu");
            }
            else
            {

                try
                {
                    using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\BGMitems.tsu"))
                    {
                        while (sr.Peek() > -1)
                        {
                            BGM_tex.Items.Add(sr.ReadLine());
                        }
                    }
                    using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\Seitems.tsu"))
                    {
                        while (sr.Peek() > -1)
                        {
                            SE_tex.Items.Add(sr.ReadLine());
                        }
                    }
                    using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\Wallpaperitems.tsu"))
                    {
                        while (sr.Peek() > -1)
                        {
                            Wallpaper_tex.Items.Add(sr.ReadLine());
                        }
                    }
                    using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\Voiceitems.tsu"))
                    {
                        while (sr.Peek() > -1)
                        {
                            Voice_tex.Items.Add(sr.ReadLine());
                        }
                    }
                }
                catch (Exception) { }
                }
           
        }
        
    }
}
