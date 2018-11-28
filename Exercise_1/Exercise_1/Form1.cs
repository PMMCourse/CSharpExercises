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

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        List<Car> CarList = new List<Car>();
        List<Car> CarListMo = new List<Car>();
        List<Car> CarListMo2 = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string outputJSON = File.ReadAllText(@"..\..\..\..\Content\Cars.json");
            CarList = JsonConvert.DeserializeObject<List<Car>>(outputJSON);
            
            //Filter mark
            var mark = CarList.Select(x => x.Maker).Distinct().ToList();
            mark.Insert(0, "No selected");
            comboBox1.DataSource = mark;

            //Filter model
            var model = CarList.Select(x => x.Model).Distinct().ToList();
            model.Insert(0, "No selected");
            comboBox2.DataSource = model;

            //Filter color
            var color = CarList.Select(x => x.Color).Where(y => y != null).Distinct().ToList();
            color.Insert(0, "No selected");
            comboBox3.DataSource = color;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 1 || comboBox3.SelectedIndex < 1)
            {
                CarListMo = CarList;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox1.SelectedItem.ToString()).ToList();
            }
            if (comboBox2.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox2.SelectedItem.ToString()).ToList();
            }
            if (comboBox3.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox3.SelectedItem.ToString()).ToList();
            }

            listBox1.DataSource = null;
            listBox1.DataSource = CarListMo;

            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = 0;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 1 || comboBox3.SelectedIndex < 1)
            {
                CarListMo = CarList;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox1.SelectedItem.ToString()).ToList();
            }
            if (comboBox2.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox2.SelectedItem.ToString()).ToList();
            }
            if (comboBox3.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox3.SelectedItem.ToString()).ToList();
            }
            listBox1.DataSource = null;
            listBox1.DataSource = CarListMo;
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = 0;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 1 || comboBox1.SelectedIndex < 1)
            {
                CarListMo = CarList;
            }
            if (comboBox1.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox1.SelectedItem.ToString()).ToList();
            }       
            if (comboBox2.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox2.SelectedItem.ToString()).ToList();
            }
            if (comboBox3.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox3.SelectedItem.ToString()).ToList();
            }

            listBox1.DataSource = null;
            listBox1.DataSource = CarListMo;

            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = null;

            if (CarListMo2.Contains(listBox1.SelectedItem))
            {
                MessageBox.Show("Ya esta en la lista");
            }
            else
            {
                CarListMo2.Add((Car)listBox1.SelectedItem);
                listBox2.DataSource = CarListMo2;
                refreshCB();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CarListMo2.Contains((Car)listBox2.SelectedItem))
            {
                CarListMo2.Remove((Car)listBox2.SelectedItem);              
                refreshCB();
            }
            else
            {
                MessageBox.Show("Not select item");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex < 1 || comboBox6.SelectedIndex < 1)
            {
                CarListMo = CarListMo2;
            }        
            if (comboBox4.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox4.SelectedItem.ToString()).ToList();
            }
            if (comboBox5.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox5.SelectedItem.ToString()).ToList();
            }
            if (comboBox6.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox6.SelectedItem.ToString()).ToList();
            }
            listBox2.DataSource = null;
            listBox2.DataSource = CarListMo;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex < 1 || comboBox6.SelectedIndex < 1)
            {
                CarListMo = CarListMo2;
            }
            if (comboBox4.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox4.SelectedItem.ToString()).ToList();
            }
            if (comboBox5.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox5.SelectedItem.ToString()).ToList();
            }
            if (comboBox6.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox6.SelectedItem.ToString()).ToList();
            }
            listBox2.DataSource = null;
            listBox2.DataSource = CarListMo;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex < 1 || comboBox5.SelectedIndex < 1)
            {
                CarListMo = CarListMo2;
            }
            if (comboBox4.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Maker == comboBox4.SelectedItem.ToString()).ToList();
            }

            if (comboBox5.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Model == comboBox5.SelectedItem.ToString()).ToList();
            }
            if (comboBox6.SelectedIndex > 0)
            {
                CarListMo = CarListMo.Select(x => x).Where(p => p.Color == comboBox6.SelectedItem.ToString()).ToList();
            }
            listBox2.DataSource = null;
            listBox2.DataSource = CarListMo;
        }
        private void refreshCB()
        {
            comboBox4.DataSource = null;
            comboBox5.DataSource = null;
            comboBox6.DataSource = null;

            //Filter mark 2
            var mark2 = CarListMo2.Select(x => x.Maker).Distinct().ToList();
            mark2.Insert(0,"No selected");
            comboBox4.DataSource = mark2;

            //Filter model 2
            var model2 = CarListMo2.Select(x => x.Model).Distinct().ToList();
            model2.Insert(0, "No selected");
            comboBox5.DataSource = model2;

            //Filter color 2
            var color2 = CarListMo2.Select(x => x.Color).Where(y => y != null).Distinct().ToList();
            color2.Insert(0, "No selected");
            comboBox6.DataSource = color2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(CarListMo2);
            f.ShowDialog();

        }
    }
    
}