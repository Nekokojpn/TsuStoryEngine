using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace TsuStoryEngine
{
    public partial class SaveWindow: Form
    {
        public SaveWindow()
        {
            InitializeComponent();
        }

        private void SaveWindow_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\REMAINING.tsu"))
            {
                REMAIN.Text = sr.ReadToEnd();
            }
            string name = "";
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
            {
                name = sr.ReadToEnd();
            }
            foreach (string stFilePath in System.IO.Directory.GetFiles(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\", "*"))
            {
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(stFilePath));
            }
            int lo1 = REMAIN.Text.IndexOf("nameof=");
            int lo2 = REMAIN.Text.IndexOf("endnameof");
            string fi = REMAIN.Text.Substring(lo1, lo2 - lo1);
            fi = fi.Substring(7);

            comboBox1.Text = Path.GetFileNameWithoutExtension(fi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ii = Interaction.InputBox("Enter number which you want.", "Enter number");
            if(ii!="")
            {

            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\Temp\Name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\"+comboBox1.Text+".tsu"))
                {
                    sw.Write(REMAIN.Text);
                }
            }
            else
            {
                MessageBox.Show("Please select file name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
