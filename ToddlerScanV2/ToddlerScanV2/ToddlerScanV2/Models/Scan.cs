using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScanV2.Models
{
    public class Scan
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int TripId { get; set; }
        public Trip trip;
        public int TeacherId { get; set; }
        public Teacher teacher;
        public List<Toddler> Toddlers { get; set; }
    }
}
