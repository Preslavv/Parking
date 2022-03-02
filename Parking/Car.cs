

namespace Parking
{
    using System.Text;
    public class Car
    {
        public Car(string make,string model,int horse_power,string registration_number)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horse_power;
            this.RegistrationNumber = registration_number;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string hp = this.HorsePower.ToString();
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"HorsePower: {hp}");
            sb.AppendLine($"RegistratrionNumber: {this.RegistrationNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
