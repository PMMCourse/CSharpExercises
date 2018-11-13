using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Dynamic;



namespace main
{
    public partial class Form1 : Form
    {
        int contador1=0;
        int contador2=0;
        int contador3=0;
        List<Car> list_coches;
        List<Car> list_coches2=new List<Car>();
        
        List<Car> Cars2= new List<Car>();
        List<Car> Cars;

        public Form1()
        {
            InitializeComponent();
            
            string outputJSON = File.ReadAllText(@"..\..\..\..\Content\Cars.json");
             Cars = JsonConvert.DeserializeObject<List<Car>>(outputJSON);


            var coches_maker = Cars.Select(x => x.Maker).Distinct().ToList();
            var coches_model = Cars.Select(x => x.Model).Distinct().ToList();
            var coches_color = Cars.Select(x => x.Color).Distinct().Where(y => y != null).ToList();

            

            comboBox1.Items.Add("not selected");
            comboBox2.Items.Add("not selected");
            comboBox3.Items.Add("not selected");
            comboBox4.Items.Add("not selected");
            comboBox5.Items.Add("not selected");
            comboBox6.Items.Add("not selected");
            /*
            
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            */
            

            foreach (String coche in coches_maker) {
                comboBox1.Items.Add(coche);        
            }
            comboBox1.SelectedIndex = 0;

            
            foreach (String coche in coches_model)
            {
                comboBox2.Items.Add(coche);
            }
            comboBox2.SelectedIndex = 0;
            
          
            foreach (String coche in coches_color)
            {
                comboBox3.Items.Add(coche);
            }
            comboBox3.SelectedIndex = 0;

            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            int num_cars = listBox2.Items.Count;
            Boolean not_Found = true;
            
            for (int i = 0; i < num_cars; i++)
            {
                if (listBox1.SelectedItem.Equals(listBox2.Items[i]))
                {
                    not_Found = false;
                }

            }
            if (not_Found)
            {

                Cars2.Add((Car)listBox1.SelectedItem);

                listBox2.Items.Add(Cars2.Last());
                


                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();

                comboBox4.Items.Add("not selected");
                comboBox5.Items.Add("not selected");
                comboBox6.Items.Add("not selected");

                var coches_maker2 = Cars2.Select(x => x.Maker).Distinct().ToList();
                var coches_model2 = Cars2.Select(x => x.Model).Distinct().ToList();
                var coches_color2 = Cars2.Select(x => x.Color).Distinct().Where(y => y != null).ToList();

                foreach (String coches in coches_maker2) {
                    comboBox4.Items.Add(coches);
                }

                foreach (String coches in coches_model2)
                {
                    comboBox5.Items.Add(coches);
                }
                foreach (String coches in coches_color2)
                {
                    comboBox6.Items.Add(coches);
                }
            }
            
            



        }


          private void button_remove_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            Cars2.Remove((Car)listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            
            
            
            var coches_maker2 = Cars2.Select(x => x.Maker).Distinct().ToList();
            var coches_model2 = Cars2.Select(x => x.Model).Distinct().ToList();
            var coches_color2 = Cars2.Select(x => x.Color).Distinct().Where(y => y != null).ToList();

           

            comboBox4.Items.Add("not selected");
            comboBox5.Items.Add("not selected");
            comboBox6.Items.Add("not selected");


            foreach (String coches in coches_maker2)
            {
                comboBox4.Items.Add(coches);
            }

            foreach (String coches in coches_model2)
            {
                comboBox5.Items.Add(coches);
            }
            foreach (String coches in coches_color2)
            {
                comboBox6.Items.Add(coches);
            }


        }

        private void button_done_Click(object sender, EventArgs e)
        {

            var data = listBox2.Items;

            cars_list windows_car_list = new cars_list(data);

            windows_car_list.ShowDialog();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            var marca = comboBox1.SelectedItem;
            var modelo = comboBox2.SelectedItem;
            var color = comboBox3.SelectedItem;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex==0 && comboBox3.SelectedIndex==0)
            {
                list_coches = Cars;
            }

            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex==0)
            {
                list_coches = Cars.Select(y => y).Where(x =>(x.Color != null && x.Color.Equals(color))).ToList();
            }
            else if  (comboBox1.SelectedIndex == 0 && comboBox3.SelectedIndex==0)
            {
                list_coches = Cars.Select(y => y).Where(x => (x.Model.Equals(modelo))).ToList();
            }
            
            else if (comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                list_coches = Cars.Select(y => y).Where(x => (x.Maker.Equals(marca))).ToList();
            }
            else if (comboBox3.SelectedIndex == 0 )
            {
                list_coches = Cars.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox2.SelectedIndex == 0)
            {
                list_coches = Cars.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }

            else if (comboBox1.SelectedIndex == 0)
            {
                list_coches = Cars.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color)) && (x.Model.Equals(modelo))).ToList();
            }


            // list_coches = Cars.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo)) && (x.Color != null && x.Color.Equals(color))).ToList();



            listBox1.DataSource = null;
            listBox1.DataSource = list_coches;


            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (contador1 == 0)
            {

                contador1++;
                contador2++;
                contador3++;

                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;



            }

            var marca = comboBox4.SelectedItem;
            var modelo = comboBox5.SelectedItem;
            var color = comboBox6.SelectedItem;

            list_coches2 = new List<Car>();

            if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2;
            }

            else if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color))).ToList();
            }
            else if (comboBox4.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca))).ToList();
            }
            else if (comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }

            else if (comboBox4.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox4.SelectedIndex != 0 && comboBox5.SelectedIndex != 0 && comboBox6.SelectedIndex != 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }


            listBox2.Items.Clear();

            foreach (Car coches in list_coches2)
            {
                listBox2.Items.Add(coches);
            }


        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (contador2 == 0)
            {

                contador1++;
                contador2++;
                contador3++;

                comboBox4.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                
                
               
            }
            

            var marca = comboBox4.SelectedItem;
            var modelo = comboBox5.SelectedItem;
            var color = comboBox6.SelectedItem;

            list_coches2 = new List<Car>();

            if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2;
            }

            else if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color))).ToList();
            }
            else if (comboBox4.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca))).ToList();
            }
            else if (comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }

            else if (comboBox4.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox4.SelectedIndex != 0 && comboBox5.SelectedIndex != 0 && comboBox6.SelectedIndex != 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }


            listBox2.Items.Clear();

            foreach (Car coches in list_coches2)
            {
                listBox2.Items.Add(coches);
            }
            


        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (contador3 == 0)
            {

                contador1++;
                contador2++;
                contador3++;

                comboBox5.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                
                
                
            }

            var marca = comboBox4.SelectedItem;
            var modelo = comboBox5.SelectedItem;
            var color = comboBox6.SelectedItem;

            list_coches2 = new List<Car>();

            if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2;
            }

            else if (comboBox4.SelectedIndex == 0 && comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color))).ToList();
            }
            else if (comboBox4.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca))).ToList();
            }
            else if (comboBox6.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox5.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }

            else if (comboBox4.SelectedIndex == 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Color != null && x.Color.Equals(color)) && (x.Model.Equals(modelo))).ToList();
            }

            else if (comboBox4.SelectedIndex != 0 && comboBox5.SelectedIndex != 0 && comboBox6.SelectedIndex != 0)
            {
                list_coches2 = Cars2.Select(y => y).Where(x => (x.Maker.Equals(marca)) && (x.Model.Equals(modelo)) && (x.Color != null && x.Color.Equals(color))).ToList();
            }

            
            listBox2.Items.Clear();

            foreach (Car coches in list_coches2)
            {
                listBox2.Items.Add(coches);
            }
            


        }
    }
}
