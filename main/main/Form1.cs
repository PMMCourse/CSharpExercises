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
            
            comboBox1.DataSource = Cars;
            comboBox2.DataSource = Cars;
            comboBox3.DataSource = Cars;

            listBox1.DataSource = Cars;


            
           


            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);





           

            






        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            var dates = listBox2.Items;

            cars_list windows_car_list = new cars_list(dates);

            windows_car_list.ShowDialog();


        }
    }
}
