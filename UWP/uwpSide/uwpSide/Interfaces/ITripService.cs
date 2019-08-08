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
        List<Trip> getAllTrips();
        IEnumerable<Toddler> getAllToddlersByTripId(int id);
    }
}
