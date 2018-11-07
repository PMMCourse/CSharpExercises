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

        static List<Car> cars1 = new List<Car>();
        static List<Car> showcars1 = new List<Car>();
        static List<Car> cars2 = new List<Car>();
        static List<Car> showcars = new List<Car>();
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
                showcars1 = cars1;
                listBox1.DataSource = showcars1;

              
            }
        }
        

    }
}

