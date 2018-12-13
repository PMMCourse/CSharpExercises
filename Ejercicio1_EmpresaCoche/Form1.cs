using Newtonsoft.Json;
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

namespace Ejercicio1_EmpresaCoche
{


    public partial class Form1 : Form
    {

        public string outputJSON;                       
        public List<Car> car_list;                  //Lista Principal de carga del json
        public List<Car> car_list2;                 //Lista Secundaria Zona derecha
        public List<int> enumerador1;               //Lista Auxiliar lista principal para saber el id de cada elemento

        public Form1()
        {
            InitializeComponent();
            outputJSON= File.ReadAllText("Cars.json");                                          //Lecutura del archivo JSON
            car_list = JsonConvert.DeserializeObject<List<Car>>(outputJSON);                    //Deserializacion en la lista principal
            car_list2 = new List<Car>();                                                //
            enumerador1 = new List<int>();                                              //Inicializacion de Listas
            car_list2.Add(car_list[0]);                                                         //Añadir la posicion NO SELECTED a la lista secundaria

            // Restriccion de no null y distintos para añadir a los combobox   

            IEnumerable<String> busmaker1 = BusCombobox(car_list,"Maker");
            IEnumerable<String> busmodelo1 = BusCombobox(car_list, "Model");
            IEnumerable<String> buscolor1 = BusCombobox(car_list, "Color");


            //Introducccion de los datos a mostra en los distintos combobox
            comboBox1.DataSource = busmaker1;
            comboBox1.DisplayMember = busmaker1.ToString();
            comboBox2.DataSource = busmodelo1;
            comboBox2.DisplayMember = busmodelo1.ToString();
            comboBox3.DataSource = buscolor1;
            comboBox3.DisplayMember = buscolor1.ToString(); 
            
            
        }
        public IEnumerable<String> BusCombobox(List<Car> o, String TipoMostrar)                             //Metodo para la creacion de restriccion de no NUll y Distintos
        {
            IEnumerable<String> res;    
            if (TipoMostrar.Equals("Color"))
                res= (from p in o where p.Color != null select p.Color).Distinct().ToList<String>();
            else if (TipoMostrar.Equals("Maker"))
                res = (from p in o select p.Maker.ToString()).Distinct().ToList<String>();
            else
                res= (from p in o select p.Model.ToString()).Distinct().ToList<String>();
            return res;
        }

        public void actualizarCombobox()                                                                   //Metodo para actualizar los combobox de la zona Derecha
        {
            
            IEnumerable<String> busmaker2 = BusCombobox(car_list2, "Maker");
            IEnumerable<String> busmodelo2 = BusCombobox(car_list2, "Model");
            IEnumerable<String> buscolor2 = BusCombobox(car_list2, "Color");
            comboBox6.DataSource = busmaker2;
            comboBox6.DisplayMember = busmaker2.ToString();
            comboBox5.DataSource = busmodelo2;
            comboBox5.DisplayMember = busmodelo2.ToString();
            comboBox4.DataSource = buscolor2;
            comboBox4.DisplayMember = buscolor2.ToString();

            
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)                  // Evento de muestre en lisBox segun la restriccion introducida en los combobox ZONA Izquierda
        {

            listBox1.Items.Clear();                     //Limpiar listBox cada vez que se modifique algun parametro de los combobox
            enumerador1.Clear();                        //Limpiar lista enumerador


            // Creacion de lista con el filtro de seleccion de los combobox

            IEnumerable<Car> ResulMostrar = from o in car_list
                                   where ((o.Maker == comboBox1.Text || comboBox1.Text =="No selected") && 
                                    (o.Model == comboBox2.Text|| comboBox2.Text == "No selected") &&
                                    (o.Color == comboBox3.Text || comboBox3.Text == "No selected"))
                                   select o;

            //Bolcado de la lista de filtracion en el listBox

                foreach (Car resultado in ResulMostrar)                                                                                 
                {                                                                                                                       
                if (resultado.Id != 0)
                    {
                        listBox1.Items.Add(resultado.Maker + " " + resultado.Model + " " + resultado.Color + " " + resultado.Year);
                        enumerador1.Add(resultado.Id);
                    }
                }
   
        }
        
        private void comboBoxDR_SelectedIndexChanged(object sender, EventArgs e)                    // Evento de muestre en lisBox segun la restriccion introducida en los combobox ZONA Derecha
        {
            listBox2.Items.Clear();                     //Limpiar listBox cada vez que se modifique algun parametro de los combobox


            // Creacion de lista con el filtro de seleccion de los combobox

            IEnumerable<Car>  ResulMostrar = from o in car_list2
                               where ((o.Maker == comboBox6.Text || comboBox6.Text == "No selected") &&
                               (o.Model == comboBox5.Text || comboBox5.Text == "No selected") &&
                               (o.Color == comboBox4.Text || comboBox4.Text == "No selected"))
                               select o;


            //Bolcado de la lista de filtracion en el listBox

            foreach (Car resultado in ResulMostrar)
            {
                if (resultado.Id != 0)
                {
                    
                    listBox2.Items.Add(resultado.Maker +" " + resultado.Model +" "+ resultado.Color +" "+ resultado.Year);
                }

            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)            //Evento click Añadir elemento selecionado a la segunda lista
        {
            int c = listBox1.SelectedIndex;
            Boolean confirmacion =false;
            IEnumerable<int> res = from o in car_list2 where o.ToString().Equals(listBox1.SelectedItem.ToString()) select 1;

            foreach(int u in res)
            {
                if (u == 1)
                {
                    MessageBox.Show("Este coche ya esta en la tabla");
                    confirmacion = true;
                }
                else
                {
                    confirmacion = false;
                }
            }
            
            if(confirmacion==false)
                car_list2.Add(car_list[enumerador1[c]]);

            actualizarCombobox();   //Utilizacion del metodo para actualizar los combobox de la Zona Derecha
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)         //Evento click Eliminar elemento selecionado de la segunda lista
        {

            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("No esta selecionado");
            }
            else
            {
                for (int i = 0; i < car_list2.Count; i++)
                {
                    if (car_list2[i].ToString().Equals(listBox2.SelectedItem.ToString()))
                    {
                        car_list2.RemoveAt(i);
                    }
                }

                actualizarCombobox();   //Utilizacion del metodo para actualizar los combobox de la Zona Derecha
            }
        }

        private void button3_Click(object sender, EventArgs e)              //Boton par mostrar la lista final
        {
            Form2 form2 = new Form2(car_list2);
            form2.ShowDialog();

        }
    }
}
