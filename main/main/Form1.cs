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
        
        Boolean first = false;
        List<Car> list_car;
        List<Car> list_car2=new List<Car>();
        List<Car> Cars;
        List<Car> Cars2= new List<Car>();


        public void fillcombo123()
        {
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            comboBox4.Items.Add("not selected");
            comboBox5.Items.Add("not selected");
            comboBox6.Items.Add("not selected");

            var cars_maker2 = Cars2.Select(x => x.Maker).Distinct().ToList();
            var cars_model2 = Cars2.Select(x => x.Model).Distinct().ToList();
            var cars_color2 = Cars2.Select(x => x.Color).Distinct().Where(y => y != null).ToList();

            foreach (String coches in cars_maker2)
            {
                comboBox4.Items.Add(coches);
            }

            foreach (String coches in cars_model2)
            {
                comboBox5.Items.Add(coches);
            }
            foreach (String coches in cars_color2)
            {
                comboBox6.Items.Add(coches);
            }
        }

        public void filllist2() {

            var marca2 = comboBox4.SelectedItem;
            var modelo2 = comboBox5.SelectedItem;
            var color2 = comboBox6.SelectedItem;



            list_car2 = Cars2;

            if (!comboBox4.SelectedIndex.Equals(0))
            {
                list_car2 = list_car2.Select(y => y).Where(x => (x.Maker.Equals(marca2))).ToList();
            }
            if (!comboBox5.SelectedIndex.Equals(0))
            {
                list_car2 = list_car2.Select(y => y).Where(x => (x.Model.Equals(modelo2))).ToList();
            }

            if (!comboBox6.SelectedIndex.Equals(0))
            {
                list_car2 = list_car2.Select(y => y).Where(x => x.Color != null && x.Color.Equals(color2)).ToList();
            }

            listBox2.Items.Clear();

            foreach (Car car in list_car2)
            {
                listBox2.Items.Add(car);
            }

        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
           
            Boolean not_Found = true;
            
            for (int i = 0; i < listBox2.Items.Count; i++)
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

                fillcombo123();

                
            }
        

        }


          private void button_remove_Click(object sender, EventArgs e)
        {
            

            Cars2.Remove((Car)listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);


            fillcombo123();

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

          
                list_car = Cars;
            

             if (!comboBox1.SelectedIndex.Equals(0) )
            {
                list_car = list_car.Select(y => y).Where(x =>(x.Maker.Equals(marca))).ToList();
            }
            if  (!comboBox2.SelectedIndex.Equals(0))
            {
                list_car = list_car.Select(y => y).Where(x => (x.Model.Equals(modelo))).ToList();
            }
            
            if (!comboBox3.SelectedIndex.Equals(0))
            {
                list_car = list_car.Select(y => y).Where(x => x.Color != null && x.Color.Equals(color)).ToList();
            }

           
            listBox1.DataSource = null;
            listBox1.DataSource = list_car;


            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!first)
            {
                first = true;
              
                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
            }

            filllist2();

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!first)
            {
                first = true;
                comboBox4.SelectedIndex = 0;
                comboBox6.SelectedIndex = 0;
                
            }

            filllist2();

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!first)
            {

                first = true;
               
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                
            }

            filllist2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string outputJSON = File.ReadAllText(@"..\..\..\..\Content\Cars.json");
            Cars = JsonConvert.DeserializeObject<List<Car>>(outputJSON);


            var cars_maker = Cars.Select(x => x.Maker).Distinct().ToList();
            var cars_model = Cars.Select(x => x.Model).Distinct().ToList();
            var cars_color = Cars.Select(x => x.Color).Distinct().Where(y => y != null).ToList();



            comboBox1.Items.Add("not selected");
            comboBox2.Items.Add("not selected");
            comboBox3.Items.Add("not selected");
            comboBox4.Items.Add("not selected");
            comboBox5.Items.Add("not selected");
            comboBox6.Items.Add("not selected");


            foreach (String car in cars_maker)
            {
                comboBox1.Items.Add(car);
            }
            comboBox1.SelectedIndex = 0;


            foreach (String car in cars_model)
            {
                comboBox2.Items.Add(car);
            }
            comboBox2.SelectedIndex = 0;


            foreach (String car in cars_color)
            {
                comboBox3.Items.Add(car);
            }
            comboBox3.SelectedIndex = 0;

        }
    }
}
