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
namespace TsuStoryEngine
{
    public partial class FIleSelector : Form
    {
        public FIleSelector()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!="")
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\temp\Selected.tsu"))
                {
                    sw.Write(comboBox1.Text);
                }
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\"+name+@"\Selecteditems.tsu"))
                {
                    string Seitems = "";
                    string Seitems_current;
                    int count3 = comboBox1.Items.Count;
                    int cou3 = 0;
                    while (cou3 < count3)
                    {

                        Seitems_current = comboBox1.Items[cou3].ToString();
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
                   
                    sw.Write(Seitems);
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\" + textBox1.Text + ".tsu"))
                {
                    sw.Write("Empty");
                }
                comboBox1.Items.Add(textBox1.Text+".tsu");
                comboBox2.Items.Add(textBox1.Text+".tsu");
            }
        }

        private void FIleSelector_Load(object sender, EventArgs e)
        {
            string name = "";
            using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
            {
                name = sr.ReadToEnd();
            }
           

           
            foreach (string stFilePath in System.IO.Directory.GetFiles(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\tex\", "*"))
            {
                comboBox1.Items.Add(Path.GetFileName(stFilePath));
                comboBox2.Items.Add(Path.GetFileName(stFilePath));
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string name = "";
                using (StreamReader sr = new StreamReader(@"C:\Resources\TsuStoryEngine\temp\name.tsu"))
                {
                    name = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Resources\TsuStoryEngine\Titles\" + name + @"\default.tsu"))
                {
                    sw.Write(comboBox2.Text);
                }
            }
        
        }
    }
}
