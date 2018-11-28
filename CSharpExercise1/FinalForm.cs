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
    public partial class FinalForm : Form
    {
        FormSettings formSettings = null;
        public FinalForm(List<Car> list)
        {
            InitializeComponent();
            FinallistBox.DataSource = list;
            FinallistBox.DisplayMember = "showinfo";

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (formSettings == null)
            {
                formSettings = new FormSettings();
            }
            formSettings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
