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
                //Los combobox se inicializan sin funcionalidad para que no dé excepcion null cuando cambie el index para poner "no selected" como predeterminado
                MakercomboBox1.Items.Add("No Selected");
                MakercomboBox1.SelectedIndex = 0;
                MakercomboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

                ModelcomboBox1.Items.Add("No Selected");
                ModelcomboBox1.SelectedIndex = 0;
                ModelcomboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

                ColorcomboBox1.Items.Add("No Selected");
                ColorcomboBox1.SelectedIndex = 0;
                ColorcomboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

                
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

            showcars1.Clear();
            showcars1.AddRange(cars1);
            if (!MakercomboBox1.SelectedItem.Equals("No Selected"))
                {
                showcars1 = showcars1.Where(x => x.Maker.Equals(MakercomboBox1.SelectedItem)).ToList();
                }
            if (!ModelcomboBox1.SelectedItem.Equals("No Selected"))
            {
                showcars1 = showcars1.Where(x => x.Model.Equals(ModelcomboBox1.SelectedItem)).ToList();
            }
            if (!ColorcomboBox1.SelectedItem.Equals("No Selected"))
            {
                showcars1 = showcars1.Where(x =>x.Color!=null && x.Color.Equals(ColorcomboBox1.SelectedItem)).ToList();
            }
            listBox1.RefreshDataSource(showcars1, "showinfo");

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!cars2.Contains(listBox1.SelectedItem))
            {
                cars2.Add((Car)listBox1.SelectedItem);
                showcars2.Add((Car)listBox1.SelectedItem);
                
            }
            
            listBox2.RefreshDataSource(showcars2, "showinfo");
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

        /* Buena idea pero quedó obsoleta con Linq
        public static void FilterList(this ComboBox comboBox, List<Car> showList, List<Car> sourceList, ListBox listBox)
        {
            showList.Clear();
            if (comboBox.SelectedItem.Equals("No Selected"))
            {
                showList.AddRange(sourceList);
            }
            else
            {
                foreach (Car c in sourceList)
                {
                    if (c.Maker.Equals(comboBox.SelectedItem))
                    {
                        showList.Add(c);
                    }
                }

            }
            listBox.RefreshDataSource(showList, "showinfo");

        }
        */
    }
}

