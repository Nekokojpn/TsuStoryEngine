﻿using System;
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
      void Save_Temp()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Temp\REMAINING.tsu"))
            {
                sw.Write(REMAINING);
            }
        }
    
    }
}
