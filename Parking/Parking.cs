



namespace Parking
{
    using System.Collections.Generic;
    public class Parking
    {
        private Dictionary<string, Car> diffcars = new Dictionary<string, Car>();
        private int capacity;

        public Parking(int capacity)
        {
            this.Capacity = capacity;
        }

        public Dictionary<string,Car> DiffCars
        {
            get { return this.diffcars; }
            set { this.diffcars = value; }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }
        public int Count { get; set; }


        public string AddCar(Car car)
        {

            if (this.DiffCars.ContainsKey(car.RegistrationNumber)) return "Car with that registration number, already exists!";
            else if (this.Count >= this.Capacity) return "Parking is full!";
            else
            {
                this.DiffCars.Add(car.RegistrationNumber, car);
                this.Count++;
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
            
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (!this.DiffCars.ContainsKey(RegistrationNumber)) return "Car with that registration number, doesn't exist!";
            else
            {
                this.DiffCars.Remove(RegistrationNumber);
                this.Count--;
                return $"Successfully removed {RegistrationNumber}";
            }
        }
        public Car GetCar(string registrationnumber)
        {
            return this.DiffCars[registrationnumber];
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            for(int i=0; i<RegistrationNumbers.Count; i++)
            {
                if(this.DiffCars.ContainsKey(RegistrationNumbers[i]))
                {
                      this.DiffCars.Remove(RegistrationNumbers[i]);
                      this.Count--;
                }
                
            }
        }
    }
}
