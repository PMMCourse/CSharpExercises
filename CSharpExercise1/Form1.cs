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


namespace CSharpExercise1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadJson();
        }


        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("cars.json"))
            {
                string json = r.ReadToEnd();

                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                listBox1.DataSource = cars ;
            }
        }
    }
}
}
