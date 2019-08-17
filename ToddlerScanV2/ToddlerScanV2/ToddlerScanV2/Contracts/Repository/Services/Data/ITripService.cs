using System;
using System.Collections.Generic;
using System.Text;
using ToddlerScanV2.Models;

namespace ToddlerScanV2.Contracts.Repository.Services.Data
{
    public interface ITripService
    {
        //Next are methods that are used if the MockAPI is still active
        Trip getTripById(int id);

        //Next are methods that need to be implemented if a real API exists
        /*
         * TaskTrip> getTripById(int id);
         */
    }
}
