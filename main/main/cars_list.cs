using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class cars_list : Form
    {
        public cars_list(object dataSource)
        {
            InitializeComponent();
            listBox1.DataSource = dataSource;
        }

        private void button_done1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cars_list_Load(object sender, EventArgs e)
        {

        }
    }
}
