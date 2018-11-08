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
        public Form1()
        {
            InitializeComponent();
            
            string outputJSON = File.ReadAllText(@"..\..\..\..\Content\Cars.json");
            List<Car> Cars = JsonConvert.DeserializeObject<List<Car>>(outputJSON);

            foreach (Car cars_values in Cars) {

                if (!comboBox1.Items.Contains(cars_values.Maker))
                {
                    comboBox1.Items.Add(cars_values.Maker);

                }
                if (!comboBox2.Items.Contains(cars_values.Model))
                {
                    comboBox2.Items.Add(cars_values.Model);

                }
                if ((cars_values.Color != null)&&!comboBox3.Items.Contains(cars_values.Color))
                {

                    comboBox3.Items.Add(cars_values.Color);

                }


            }

            
           
            
            listBox1.DataSource = Cars;


            



            
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            int num_cars = listBox2.Items.Count;
            Boolean not_Found = true;
            
                for (int i = 0; i <num_cars; i++)
                {
                    if (listBox1.SelectedItem.Equals(listBox2.Items[i]))
                    {
                     not_Found = false;
                    }
                    
                }
                if (not_Found)
                    {
                      listBox2.Items.Add(listBox1.SelectedItem);
                    }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button_done_Click(object sender, EventArgs e)
        {

            var data = listBox2.Items;

            cars_list windows_car_list = new cars_list(data);

            windows_car_list.ShowDialog();


        }
    }
}
