namespace Need_For_Speed.Factories
{
    using Models;
    using Models.Races;
    using System;

    public class RaceFactory
    {
        public Race GetRace(string raceType, int length, string route, int prizePool, int lastParam)
        {
            switch (raceType)
            {
                case "Casual":
                    return new CasualRace(length, route, prizePool);
                case "Drag":
                    return new DragRace(length, route, prizePool);
                case "Drift":
                    return new DriftRace(length, route, prizePool);
                case "TimeLimit":
                    return new TimeLimitRace(length, route, prizePool, lastParam);
                case "Circuit":
                    return new CircuitRace(length, route, prizePool, lastParam);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
