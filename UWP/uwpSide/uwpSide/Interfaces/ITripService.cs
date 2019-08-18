using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uwpSide.Models;

namespace uwpSide.Interfaces
{
    public interface ITripService
    {

        //Netx are methods that are used if the MockAPI is still active
        List<Trip> getAllTrips();
        IEnumerable<Toddler> getAllToddlersByTripId(int id);

        void addTrip(Trip trip);

        int getTotalTripsNumber();

        //Next are methods that need to be implemented if a real API exists
        /*
         * Task<IEnumerable<Trip>> getAllTrips();
         * Task<IEnumerable<Toddler>> getAllToddlersByTripId(int id);
         * Task<Trip> addTrip(Trip trip);
         * Task<int> getTotalTripsNumber();
         * 
         * **/
    }
}
