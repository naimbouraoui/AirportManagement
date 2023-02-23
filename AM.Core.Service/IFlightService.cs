using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Service
{
    public interface IFlightService
    {
        IList<DateTime> GetFlightDates(String Destination);
        void GetFlights(string filterType, string filterValue);
    }
}
