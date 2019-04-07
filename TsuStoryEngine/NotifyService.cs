using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsuStoryEngine
{
    public partial class NotifyService: Form
    {
        public NotifyService()
        {
            InitializeComponent();
        }

        private void NotifyService_Load(object sender, EventArgs e)
        {
            this.Hide();
            
            string tex = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Resources\TsuStoryEngine\temp\notify.tsu"))
            {
                tex = sr.ReadToEnd();
            }
            notifyIcon1.Text = tex;
        }
    }
}
