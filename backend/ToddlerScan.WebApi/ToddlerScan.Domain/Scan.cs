using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScan.Domain
{
    public class Scan
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int TripId { get; set; }
        public List<ToddlerScan> ToddlerScans { get; set; }
    }
}
