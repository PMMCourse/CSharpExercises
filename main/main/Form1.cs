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

            
           


            
        }
        
    }
}
