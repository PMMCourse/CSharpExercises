using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Exercise1
{
    public partial class Menu_Principal : Form
    {
        List<Coche> listacoches = new List<Coche>();
        List<Coche> listacochesModificar = new List<Coche>();
        List<Coche> listToListBox = new List<Coche>();

        public Menu_Principal()
        {
            InitializeComponent();
        }//end constructor

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            string outputJSON = File.ReadAllText("Cars.json");
            listacochesModificar.Clear();
            listacoches = JsonConvert.DeserializeObject<List<Coche>>(outputJSON);
            cargarfiltros("izquierda");
            lbReadJason.SelectedIndex = 0;
        }//end load


        private void cbMarcaRead_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("izquierda");
        }//end void

        private void cbModeloRead_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("izquierda");
        }//end void

        private void cbColorRead_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("izquierda");
        }//end void

        private void cbMarcaWritter_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("derecha");
        }//end void

        private void cbModeloWritter_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("derecha");
        }//end void

        private void cbColorWritter_SelectedIndex(object sender, EventArgs e)
        {
            updateListbox("derecha");
        }//end void

        private void btadd_Click(object sender, EventArgs e)
        {
            if (!listacochesModificar.Contains(listacoches[lbReadJason.SelectedIndex]))
            {
                listacochesModificar.Add(listacoches[lbReadJason.SelectedIndex]);
                updateListbox("derecha");
                lbWritteJason.SelectedIndex = 0;
                cargarfiltros("derecha");
            }//end if
            else
            {
                MessageBox.Show("Este coche esta ya insertado");
            }//end else
              
        }//end void

        private void btdel_Click(object sender, EventArgs e)
        {
            listacochesModificar.RemoveAt(lbWritteJason.SelectedIndex);
            updateListbox("derecha");
            cargarfiltros("derecha");

        }//end void

        private void btaceptar_Click(object sender, EventArgs e)
        {
            FModificar_Coches FMW = new FModificar_Coches(listacochesModificar);
            FMW.ShowDialog();
        }//end void

        private void cargarfiltros(string filtros)
        {

            switch (filtros)
            {
                case "izquierda":
                    cbMarcaRead.Items.Add("No Selected");
                    var MarcaNotNullRead = listacoches.Select(coche => coche.Maker).Where(marca => marca != null).Distinct().ToList();
                    foreach (var marca in MarcaNotNullRead)
                    {
                        cbMarcaRead.Items.Add(marca);
                    }//end foreach
                    cbMarcaRead.SelectedIndex = 0;

                    cbModeloRead.Items.Add("No Selected");
                    var ModeloNotNullRead = listacoches.Select(coche => coche.Model).Where(modelo => modelo != null).Distinct().ToList();
                    foreach (var modelo in ModeloNotNullRead)
                    {
                        cbModeloRead.Items.Add(modelo);
                    }//end foreach
                    cbModeloRead.SelectedIndex = 0;

                    cbColorRead.Items.Add("No Selected");
                    var ColorNotNullRead = listacoches.Select(coche => coche.Color).Where(color => color != null).Distinct().ToList();
                    foreach (var color in ColorNotNullRead)
                    {
                        cbColorRead.Items.Add(color);
                    }//end foreach
                    cbColorRead.SelectedIndex = 0;
                    break;

                case "derecha":
                    cbMarcaWritter.Items.Clear();
                    cbColorWritter.Items.Clear();
                    cbModeloWritter.Items.Clear();
                    cbMarcaWritter.Items.Add("No Selected");
                    cbMarcaWritter.SelectedIndex = 0;
                    var MarcaNotNullWritter = listacochesModificar.Select(coche => coche.Maker).Where(marca => marca != null).Distinct().ToList();
                    foreach (var marca in MarcaNotNullWritter)
                    {
                        cbMarcaWritter.Items.Add(marca);
                    }//end foreach


                    cbModeloWritter.Items.Add("No Selected");
                    cbModeloWritter.SelectedIndex = 0;
                    var ModeloNotNullWritter = listacochesModificar.Select(coche => coche.Model).Where(modelo => modelo != null).Distinct().ToList();
                    foreach (var modelo in ModeloNotNullWritter)
                    {
                        cbModeloWritter.Items.Add(modelo);
                    }//end foreach


                    cbColorWritter.Items.Add("No Selected");
                    cbColorWritter.SelectedIndex = 0;
                    var ColorNotNullWritter = listacochesModificar.Select(coche => coche.Color).Where(color => color != null).Distinct().ToList();
                    foreach (var color in ColorNotNullWritter)
                    {
                        cbColorWritter.Items.Add(color);
                    }//end foreach
                    break;
            }//end switch

        }//end void
        private void updateListbox(string listview)
        {

            switch (listview)
            {
                case "izquierda":
                    lbReadJason.Items.Clear();
                    listToListBox = listacoches;

                    if (cbMarcaRead.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Maker == cbMarcaRead.SelectedItem.ToString()).ToList();
                    }//end if
                    if (cbModeloRead.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Model == cbModeloRead.SelectedItem.ToString()).ToList();
                    }//end if
                    if (cbColorRead.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Color == cbColorRead.SelectedItem.ToString()).ToList();
                    }//end if

                    foreach (var items in listToListBox)
                    {
                        lbReadJason.Items.Add(items.Maker + " " + items.Model + " " + items.Color + " " + items.Year);
                    }//end foreach
                    
                    break;

                case "derecha":
                    lbWritteJason.Items.Clear();
                    listToListBox = listacochesModificar;

                    if (cbMarcaWritter.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Maker == cbMarcaWritter.SelectedItem.ToString()).ToList();
                    }//end if
                    if (cbModeloWritter.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Model == cbModeloWritter.SelectedItem.ToString()).ToList();
                    }//end if
                    if (cbColorWritter.SelectedIndex > 0)
                    {
                        listToListBox = listToListBox.Where(coche => coche.Color == cbColorWritter.SelectedItem.ToString()).ToList();
                    }//end if
                    
                    foreach (var items in listToListBox)
                    {
                        lbWritteJason.Items.Add(items.Maker + " " + items.Model + " " + items.Color + " " + items.Year);
                    }//end foreach
                    break;
            }//end switch
        }//end void
                
        
}//end class

}//end namespace
