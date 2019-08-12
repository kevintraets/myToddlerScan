using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Contracts.Repository.Services.Data;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Services.Data
{
    public class TripService : ITripService
    {
        public Trip getTripById(int id)
        {
            return MockAPI.MockAPI.getTripById(id);
        }

 
    }
}
