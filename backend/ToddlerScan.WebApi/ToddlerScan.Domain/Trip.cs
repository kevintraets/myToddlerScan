using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScan.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public Teacher Teacher { get; set; }
        public List<Scan> Scans { get; set; }
        public List<ToddlerTrip> ToddlerTrips { get; set; }

    }
}
