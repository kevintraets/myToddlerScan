using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Interfaces;
using uwpSide.Models;

namespace uwpSide.Services
{
    public class TripService : ITripService
    {
        public IEnumerable<Toddler> getAllToddlersByTripId(int id)
        {
            return MockAPI.MockAPI.getAllToddlersFromTripByTripId(id);
        }

        public List<Trip> getAllTrips()
        {
            return MockAPI.MockAPI.getAllTripsMock();
        }

        public void addTrip(Trip trip)
        {
            MockAPI.MockAPI.addTrip(trip);
        }


    }
}
