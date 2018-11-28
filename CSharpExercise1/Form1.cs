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
 
                foreach (Car c in jsoncars)
                {
                    c.Initialize();
                    cars1.Add(c);
                    
                }

                showcars1.AddRange(cars1);
                listBox1.DataSource = showcars1;
                listBox1.DisplayMember = "showinfo";

                InitializeComboBox(MakercomboBox1, cars1.Select(x=>x.Maker).Distinct().ToList(), Left_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ModelcomboBox1, cars1.Select(x=>x.Model).Distinct().ToList(), Left_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ColorcomboBox1, cars1.Select(x=> x.Color).Where(y=>y!=null).Distinct().ToList(), Left_ComboBox_SelectedIndexChanged);




            }
        }
        private void InitializeComboBox(ComboBox combobox, List<String> sourceList, EventHandler eventhandler)
        {
            sourceList.Insert(0, "No Selected");
            combobox.DataSource = sourceList;
            combobox.SelectedIndex = 0;
            combobox.SelectedIndexChanged -= eventhandler;
            combobox.SelectedIndexChanged += eventhandler;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (!cars2.Contains(listBox1.SelectedItem))
            {
                cars2.Add((Car)listBox1.SelectedItem);
                showcars2.Add((Car)listBox1.SelectedItem);

                InitializeComboBox(MakercomboBox2, cars2.Select(x => x.Maker).Distinct().ToList(), Right_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ModelcomboBox2, cars2.Select(x => x.Model).Distinct().ToList(), Right_ComboBox_SelectedIndexChanged);
                InitializeComboBox(ColorcomboBox2, cars2.Select(x => x.Color).Where(y => y != null).Distinct().ToList(), Right_ComboBox_SelectedIndexChanged);
                

            }
            
            listBox2.RefreshDataSource(showcars2, "showinfo");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                cars2.RemoveAt(listBox2.SelectedIndex);
                showcars2.RemoveAt(listBox2.SelectedIndex);
                listBox2.RefreshDataSource(showcars2, "showinfo");
            }
            

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

    }
}

