using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Coche
    {
        public int id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public Location Location { get; set; }

        public static explicit operator Coche(List<Coche> v)
        {
            throw new NotImplementedException();
        }
    }//end class

    public class Location
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }//end class



}//end namespace
