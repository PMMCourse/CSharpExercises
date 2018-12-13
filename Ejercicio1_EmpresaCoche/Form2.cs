using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_EmpresaCoche
{
    public partial class Form2 : Form
    {

        List<Car> lista_coches;                                          //Atributo lista en el que cargaremos la lista pasada desde el form1

        
        public Form2(List<Car> car_list)
        {
            InitializeComponent();

            lista_coches = car_list;                                    //Inicializacion de la lista
        }

        private void Form2_Load(object sender, EventArgs e)             //Carga la lista en el listBox
        {
            foreach(Car C in lista_coches)
            {
                if(C.Id!=0)
                    listBox1.Items.Add(C);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String res="";
            res += "Creado con amor para Chema"+"\n";
            res += "Autor: Enrique Rojas Millán" + "\n";
            res += "\n";
            res += "Version : 1.0.0.0" + "\n";
            MessageBox.Show(res);
        }
    }
}
