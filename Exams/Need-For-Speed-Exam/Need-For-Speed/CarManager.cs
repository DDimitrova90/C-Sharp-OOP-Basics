namespace Need_For_Speed
{
    using Factories;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class CarManager
    {
        private CarFactory carFactory;
        private RaceFactory raceFactory;
        private Dictionary<int, Car> cars;
        private Dictionary<int, Race> races;
        private Garage garage;

        public CarManager()
        {
            this.carFactory = new CarFactory();
            this.raceFactory = new RaceFactory();
            this.cars = new Dictionary<int, Car>();
            this.races = new Dictionary<int, Race>();
            this.garage = new Garage();
        }

        public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            Car currCar = carFactory.GetCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);

            cars.Add(id, currCar);
        }

        public string Check(int id)
        {
            Car car = cars.FirstOrDefault(c => c.Key == id).Value;
            return car.ToString();
        }

        public void Open(int id, string type, int length, string route, int prizePool, int lastParam)
        {
            Race currRace = raceFactory.GetRace(type, length, route, prizePool, lastParam);

            races.Add(id, currRace);
        }

        public void Participate(int carId, int raceId)
        {
            Car currCar = cars.FirstOrDefault(c => c.Key == carId).Value;
            Race currRace = races.FirstOrDefault(r => r.Key == raceId).Value;

            if (!this.garage.ParkedCars.Contains(currCar))
            {
                currRace.AddParticipant(currCar);
            }
        }

        public string Start(int id)
        {
            Race currRace = races.FirstOrDefault(r => r.Key == id).Value;

            if (currRace.Participants.Count() == 0)
            {
                return "Cannot start the race with zero participants.";
            }

            races.Remove(id);

            return currRace.Start();
        }

        public void Park(int id)
        {
            Car currCar = cars.FirstOrDefault(c => c.Key == id).Value;

            if (races.Where(r => r.Value.Participants.Contains(currCar)).Count() == 0)
            {
                this.garage.ParkedCars.Add(currCar);
            }
        }

        public void Unpark(int id)
        {
            Car currCar = cars.FirstOrDefault(c => c.Key == id).Value;
            this.garage.ParkedCars.Remove(currCar);
        }

        public void Tune(int tuneIndex, string addOn)
        {
            if (this.garage.ParkedCars.Count() > 0)
            {
                foreach (var car in this.garage.ParkedCars)
                {
                    car.Horsepower += tuneIndex;
                    car.Suspension += tuneIndex / 2;
                    car.Tune(tuneIndex, addOn);
                }
            }
        }
    }

}
