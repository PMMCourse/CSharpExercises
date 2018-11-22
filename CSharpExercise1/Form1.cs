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
            
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadJson();
        }


        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("Cars.json"))
            {
                string json = r.ReadToEnd();

                List<Car> jsoncars = JsonConvert.DeserializeObject<List<Car>>(json);
                //Los combobox se inicializan sin funcionalidad para que no dé excepcion null cuando cambie el index para poner "no selected" como predeterminado
                

                foreach (Car c in jsoncars)
                {
                    c.Initialize();
                    cars1.Add(c);
                    
                }

                
                showcars1.AddRange(cars1);
                listBox1.DataSource = showcars1;

                
                InitializeComboBox(MakercomboBox1,cars1,Left_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ModelcomboBox1, cars1, Left_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ColorcomboBox1, cars1, Left_ComboBox_SelectedIndexChanged);
            }
        }

        private void InitializeComboBox(ComboBox comboBox, List<Car> sourceList, EventHandler eventhandler )
        {
            List<string> list = new List<string> { "No Selected" };
            list.AddRange(Select_comboBox(comboBox, sourceList).ToList());
            comboBox.DataSource = null;
            comboBox.DataSource = list;
            comboBox.SelectedIndex = 0;

            comboBox.SelectedIndexChanged -= eventhandler;
            comboBox.SelectedIndexChanged += eventhandler;
        }

        private IEnumerable<string> Select_comboBox(ComboBox comboBox, List<Car> sourceList)
        {
            IEnumerable<string> list=null;
            switch (comboBox.Tag)
            {
                case "maker":
                    {
                        list = sourceList.Select(x => x.Maker).Distinct();
                        break;
                    }
                case "model":
                    {
                        list = sourceList.Select(x => x.Model).Distinct();
                        break;
                    }
                case "color":
                    {
                        list = sourceList.Select(x => x.Color).Distinct();
                        break;
                    }
    
            }

            return list;
        }




        private void Left_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Right_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            showcars2.Clear();
            showcars2.AddRange(cars2);
            if (!MakercomboBox2.SelectedItem.Equals("No Selected"))
            {
                showcars2 = showcars2.Where(x => x.Maker.Equals(MakercomboBox2.SelectedItem)).ToList();
            }
            if (!ModelcomboBox2.SelectedItem.Equals("No Selected"))
            {
                showcars2 = showcars2.Where(x => x.Model.Equals(ModelcomboBox2.SelectedItem)).ToList();
            }
            if (!ColorcomboBox2.SelectedItem.Equals("No Selected"))
            {
                showcars2 = showcars2.Where(x => x.Color != null && x.Color.Equals(ColorcomboBox2.SelectedItem)).ToList();
            }
            listBox2.RefreshDataSource(showcars2, "showinfo");

        }

        private void Filter_ComboBox(ListBox listBox, ComboBox makerComboBox, ComboBox modelComboBox, ComboBox colorComboBox)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (!cars2.Contains(listBox1.SelectedItem))
            {
                cars2.Add((Car)listBox1.SelectedItem);
                showcars2.Add((Car)listBox1.SelectedItem);

                InitializeComboBox(MakercomboBox2, cars2, Right_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ModelcomboBox2, cars2, Right_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ColorcomboBox2, cars2, Right_ComboBox_SelectedIndexChanged);

                
            }
            

            listBox2.RefreshDataSource(showcars2, "showinfo");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            
            FinalForm finalform = new FinalForm(cars2);
            finalform.ShowDialog();
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

