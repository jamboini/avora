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
    public partial class set_dialog : Form
    {
        public string profilepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\jphweb\avora_profile\";
        
        public set_dialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(profilepath + "home.jpf");
            file.Write(home());
            file.Close();
        }

        public string home()
        {
            if (textBox1.Text == "")
            {
                StreamReader sr = new StreamReader(profilepath + "home.jpf");
                return sr.ReadLine();
            }
            else
            {
                return textBox1.Text;
            }
        }

        private void set_dialog_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(profilepath + "home.jpf");
            textBox1.Text = sr.ReadLine();
        }
    }
}
