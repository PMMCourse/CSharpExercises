using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace main
{
    class Car
    {
      

        
        
            public int id { get; set; }
            public string Maker { get; set; }
            public string Model { get; set; }
            public int? Year { get; set; }
            public string Color { get; set; }
            public Location Location { get; set; }

            public override string ToString()
            {
                return id +" "+ Maker +" "+ Model+" " + Year+" " + Color;
            }



                

       

    }
            public class Location
             {
                   public object Latitude { get; set; }
                   public object Longitude { get; set; }
              }
    


}
