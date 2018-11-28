using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form2 : Form
    {
        List<Car> c = new List<Car>();

        public Form2(List<Car> c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = c;
        }

        
    }
}
