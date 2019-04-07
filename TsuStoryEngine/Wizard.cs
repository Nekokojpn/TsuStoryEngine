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
using System.Windows;

namespace TsuStoryEngine
{
    public partial class Wizard : Form
    {
        public Wizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            comboBox1.Text = openFileDialog1.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception)
            {

            }
        }
        void me(string tex, string title)
        {
            System.Windows.MessageBox.Show(tex, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool mode = false;
            try
            {
                if (Directory.Exists(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                mode = true;
                me("This name already taken. Please retry another name.", "");
            }
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "") 
            {
                if (mode == false)
                {
                    // try
                    {
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\BGM");
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\im");
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\tex");
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\wp");
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\vo");
                        Directory.CreateDirectory(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\se"); 
                        string pp = Path.GetExtension(comboBox1.Text); File.Copy(comboBox1.Text, @"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\im\Title." + pp);
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\Name.tsu"))
                        {
                            sw.Write(textBox1.Text);
                        }
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\NameP.tsu"))
                        {
                            sw.Write(textBox2.Text);
                        }
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\TitleImage.tsu"))
                        {
                            sw.Write(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\im\Title." + pp);
                        }
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\Name.tsu"))
                        {
                            sw.Write(textBox1.Text);
                        }
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\NameP.tsu"))
                        {
                            sw.Write(textBox2.Text);
                        }
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\TitleImage.tsu"))
                        {
                            sw.Write(@"C:\Resources\TsuStoryEngine\Titles\" + textBox1.Text + @"\im\Title." + pp);
                        }
                        
                        using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\First.tsu"))
                        {
                            sw.Write("y");
                        }
                        this.Close();
                        //   }
                        //   catch (Exception)
                        //    {

                        //     }
                    }

                }
                else
                {
                    me("Do not set to empty area which textbox or combobox.", "");
                }
            }
        }
    }
}

