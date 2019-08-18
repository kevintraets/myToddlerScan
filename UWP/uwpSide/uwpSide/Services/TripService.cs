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

        //Next are the implementations of the MockApi, delete methods when the real api exists.
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

        public int getTotalTripsNumber()
        {
           return MockAPI.MockAPI.getNumberOfTrips();
        }

        //Next are the implementations if a real API exists.
        /*
         * private IGenericRepository _genericRepository;
         * public TripService(IGenericRepository genericRepository)
         * {
         *      genericRepository = AppContainer.Resolve<IGenericRepository>();
         *      _genericRepository = genericRepository;
         * }
         * public async Task<IEnumerable<Trip> getAllTrips()
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {   
         *          Path = ApiConstants.Trip;
         *      };
         *      var trips = await _genericRepository.GetAsync<List<Trip>>(builder.ToString());
         *      return trips;
         * }
         * public async Task<Trip> addTrip(Trip trip)
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = ApiConstants.Trip;
         *      }
         *      var tripToAdd = await _genericRepositoryPostAsync(builder.ToString(), trip);
         *      return tripToAdd;
         * }
         * **/
    }
}
