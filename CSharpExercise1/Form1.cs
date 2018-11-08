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
using Newtonsoft.Json;


namespace CSharpExercise1
{
    

    public partial class Main : Form
    {

         List<Car> cars1 = new List<Car>();
         List<Car> showcars1 = new List<Car>();
         List<Car> cars2 = new List<Car>();
         List<Car> showcars2 = new List<Car>();
        public Main()
        {
            InitializeComponent();
            LoadJson();
            
        }
        
        
       

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("Cars.json"))
            {
                string json = r.ReadToEnd();

                List<Car> jsoncars = JsonConvert.DeserializeObject<List<Car>>(json);
                MakercomboBox1.Items.Add("No Selected");
                
                ModelcomboBox1.Items.Add("No Selected");
                ColorcomboBox1.Items.Add("No Selected");

                foreach (Car c in jsoncars)
                {
                    c.Initialize();
                    cars1.Add(c);
                    if (!MakercomboBox1.Items.Contains(c.Maker))
                    {
                        MakercomboBox1.Items.Add(c.Maker);
                    }
                    if (!ModelcomboBox1.Items.Contains(c.Model))
                    {

                        ModelcomboBox1.Items.Add(c.Model);
                    }
                    if (c.Color != null && !ColorcomboBox1.Items.Contains(c.Color))
                    {

                        ColorcomboBox1.Items.Add(c.Color);
                    }
                }

                
                showcars1.AddRange(cars1);
                listBox1.DataSource = showcars1;

              
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //((ComboBox)sender).FilterList(showcars1,cars1,listBox1);
            
            
            showcars1 = cars1.Where(car => car.Maker == MakercomboBox1.SelectedItem.ToString()||MakercomboBox1.SelectedItem.Equals("No selected")).ToList();
            listBox1.RefreshDataSource(showcars1,"showinfo");
        }

        private void MakercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            showcars1.Clear();
            if (MakercomboBox1.SelectedItem.Equals("No Selected"))
            {
                showcars1.AddRange(cars1);
            }
            else {
                foreach (Car c in cars1)
                {
                    if (c.Maker.Equals(MakercomboBox1.SelectedItem)){
                        showcars1.Add(c);
                    }
                }
                
            }
            listBox1.RefreshDataSource(showcars1, "showinfo");
            
        }

        private void ModelcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public static class Extensions
    {
       
        public static void RefreshDataSource(this ListBox listbox, List<Car> dataSource, string displayMember)
        {
            listbox.DataSource = null;
            listbox.DataSource = dataSource;
            listbox.DisplayMember = displayMember;
            
        }

        public static void FilterList(this ComboBox comboBox, List<Car> showList, List<Car> sourceList, ListBox listBox)
        {
            showList.Clear();


            if (comboBox.SelectedItem.Equals("No Selected"))
            {
                showList.AddRange(sourceList);
            }
            else
            {
                showList = sourceList.Where(x => x.Maker==comboBox.SelectedItem.ToString()).ToList();
                /*
                foreach (Car c in sourceList)
                {
                    if (c.Maker.Equals(comboBox.SelectedItem))
                    {
                        showList.Add(c);
                    }
                }

            }*/
                
            }
            listBox.RefreshDataSource(showList, "showinfo");
        }
    }
}

