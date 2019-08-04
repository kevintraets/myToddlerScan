using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScan.Domain
{
    public class ToddlerTrip
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public int ToddlerId { get; set; }
        public Toddler Toddler { get; set; }
    }
}
