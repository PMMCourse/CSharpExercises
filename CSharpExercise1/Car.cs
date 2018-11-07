using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpExercise1
{
    


        public class Rootobject
        {
            public Car[] Property1 { get; set; }
        }

        public class Car
        {
            public int id { get; set; }
            public string Maker { get; set; }
            public string Model { get; set; }
            public int? Year { get; set; }
            public string Color { get; set; }
            public Location Location { get; set; }
            public string showInfo { get; set; } 
        
            public void Initialize()
        {
            showInfo = toString();
        }

            public String toString()
        {
            return $"{Maker} {Model} {Year} {Color} ";
        }
            
        }

        public class Location
        {
            public object Latitude { get; set; }
            public object Longitude { get; set; }
        }



    
}
