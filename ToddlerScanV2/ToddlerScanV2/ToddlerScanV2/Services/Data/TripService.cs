using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class TripService : ITripService
    {
        //Next are the implementations of the MockApi, delete methods when the API exists.
        public Trip getTripById(int id)
        {
            return MockAPI.MockAPI.getTripById(id);
        }
        //Next are the implementations if a real API exists.
        /*
         * private IGenericRepository _genericRepository;
         * public TripService(IGenericRepository genericRepository)
         * {
         *      _genericRepository = genericRepository
         * }
         * public async Task<Trip> getTripById(int id)
         * {
         *      UriBuilder builder = new UriBuilder(ApiConstants.BaseApiUrl)
         *      {
         *          Path = $"{ApiConstants.Trip}/{id};
         *      };
         *      return await _genericRepository.GetAsync<Trip>(builder.ToString());
         * }
         */
 
    }
}
