namespace Ejercicio1_EmpresaCoche
{
    public class Location
    {
        private double? latitude;
        private double? longitude;


        public double? Latitude {
            get {
                return latitude;
            }
            set {
                latitude = value;
            }
        }
        public double? Longitude {
            get {
                return longitude;
            }
            set {
                longitude = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
