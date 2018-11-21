using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class FModificar_Coches : Form
    {
        List<Coche> listacochesModificar = new List<Coche>();
        public FModificar_Coches(List<Coche> listacochesModificar)
        {
            this.listacochesModificar = listacochesModificar;
            InitializeComponent();
        }//end constructor

        private void FMWLoad(object sender, EventArgs e)
        {
            foreach (var coches in listacochesModificar)
            {
                lbCocheModificar.Items.Add(coches.Maker + " " + coches.Model + " " + coches.Color + " " + coches.Year);
            }//end foreach
        }//end void

    }//end class
}//end namespace
