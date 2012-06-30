using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avora
{
    public partial class Form1 : Form
    {
        public string profilepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\jphweb\avora_profile\";

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            set_dialog sd = new set_dialog();
            sd.Show();
        }

        private void startup(object sender, EventArgs e)
        {
            if (File.Exists(profilepath + "firstrun.jpf"))
            {

            }

            else
            {
                firstrun();
            }
        }

        private void firstrun()
        {
            if (!Directory.Exists(profilepath))
            {
                DirectoryInfo di = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\jphweb\avora_profile");
            }

            if (!File.Exists(profilepath + "firstrun.jpf"))
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(profilepath + "firstrun.jpf");
                file.Write("");
                file.Close();
            }
            
            if (!File.Exists(profilepath + "home.jpf"))
            {
                System.IO.StreamWriter file2 = new System.IO.StreamWriter(profilepath + "home.jpf");
                file2.Write("http://www.google.com");
                file2.Close();
            }
        }
    }
}
