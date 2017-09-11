namespace Need_For_Speed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private bool isRunning;
        private CarManager carManager;

        public Engine()
        {
            this.isRunning = true;
            this.carManager = new CarManager();
        }

        public void Run()
        {
            while (this.isRunning)
            {
                string inputCommand = this.ReadInput();

                if (inputCommand == "Cops Are Here")
                {
                    this.isRunning = false;
                    continue;
                }

                List<string> commandParameters = this.ParseInput(inputCommand);
                this.DistributeCommand(commandParameters);
            }
        }

        private void DistributeCommand(List<string> commandParameters)
        {
            string command = commandParameters[0];
            commandParameters.Remove(command);

            switch (command)
            {
                case "register":
                    int id = int.Parse(commandParameters[0]);
                    string type = commandParameters[1];
                    string brand = commandParameters[2];
                    string model = commandParameters[3];
                    int yearOfProduction = int.Parse(commandParameters[4]);
                    int horsePower = int.Parse(commandParameters[5]);
                    int acceleration = int.Parse(commandParameters[6]);
                    int suspension = int.Parse(commandParameters[7]);
                    int durability = int.Parse(commandParameters[8]);
                    this.carManager.Register(id, type, brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                    break;
                case "check":
                    id = int.Parse(commandParameters[0]);
                    string car = this.carManager.Check(id);
                    this.OutputWriter(car);
                    break;
                case "open":
                    id = int.Parse(commandParameters[0]);
                    type = commandParameters[1];
                    int length = int.Parse(commandParameters[2]);
                    string route = commandParameters[3];
                    int prizePool = int.Parse(commandParameters[4]);
                    int lastParam = 0;
                    if (commandParameters.Count() > 5)
                    {
                        lastParam = int.Parse(commandParameters[5]);
                    }
                    this.carManager.Open(id, type, length, route, prizePool, lastParam);
                    break;
                case "participate":
                    int carId = int.Parse(commandParameters[0]);
                    int raceId = int.Parse(commandParameters[1]);
                    this.carManager.Participate(carId, raceId);
                    break;
                case "start":
                    raceId = int.Parse(commandParameters[0]);
                    string result = this.carManager.Start(raceId);
                    this.OutputWriter(result);
                    break;
                case "park":
                    carId = int.Parse(commandParameters[0]);
                    this.carManager.Park(carId);
                    break;
                case "unpark":
                    carId = int.Parse(commandParameters[0]);
                    this.carManager.Unpark(carId);
                    break;
                case "tune":
                    int tuneIndex = int.Parse(commandParameters[0]);
                    string addOn = commandParameters[1];
                    this.carManager.Tune(tuneIndex, addOn);
                    break;
            }
        }

        private void OutputWriter(string car)
        {
            Console.WriteLine(car);
        }

        private List<string> ParseInput(string inputCommand)
        {
            return inputCommand
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }

        private string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
