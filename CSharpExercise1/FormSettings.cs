using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExercise1
{
    public partial class FormSettings : Form
    {
        
        private string path;
        public FormSettings()
        {
            InitializeComponent();
            path = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default["Path"] = textBox1.Text;
            Properties.Settings.Default.Save();
             
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Path;

        }
    }
}
