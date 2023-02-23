using AM.Core.Domain;

namespace AM.Core.Service
{
    public class FlightService : IFlightService
    {
        public IList<Flight> Flights { get; set; }
        public IList<DateTime> GetFlightDates(String Destiation)
        {
        //    List<DateTime> dates = new List<DateTime>(); 
         //   foreach (var flight in Flights)
          //  {
            //    if (flight.Destination == Destiation)
              //  {
                //    dates.Add(flight.FlightDate);
                //}
            //}
            //return dates;
            //linQ INTEGRé TP2 Question6
        //    return (from flight in Flights
        //            where flight.Destination == Destiation 
        //            select flight.FlightDate).ToList();
        //2eme methode
        return Flights.Where(f =>f.Destination == Destiation).Select(f =>f.FlightDate).ToList();
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightId":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                default:Console.WriteLine("ERROR");
                    break;
            }
        }
        public void ShowFlightDetails(int planeid)
        {
            var flights=Flights.Where(f => f.MyPlane.PlaneId == planeid);
            foreach (var flight in flights)
            {
                Console.WriteLine(flight.Destination,flight.FlightDate);
            }
       }
        public int GetWeeklyFlightNumber(DateTime StartDate)
        {
            var EndDate = StartDate.AddDays(7);
            var flights=Flights.Where(f=>f.FlightDate>=StartDate && f.FlightDate< EndDate);
            return flights.Count();
        }
        public double GetDurationAverage(String destination)
        {
            return Flights.Where(f => f.Destination == destination).Average(f => f.EstimatedDuration);
            }
        public IList<Flight> SortFlights()
        {
            return Flights.OrderByDescending(f=>f.EstimatedDuration).ToList();  
        }
        public IList<Passenger> GetThreeOlderTravellers()
        {
            return Flights.SelectMany(f => f.passengers).OrderByDescending(p => p.Age).Take(3).ToList();
        }
        public void ShowGroupedFlights()
        {
            var flights = Flights.GroupBy(f => f.Destination);
            foreach (var flight in flights)
            {
                Console.WriteLine(flight);
            }
        }

    }
}