using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Models
{
    public class Scan
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int TripId { get; set; }
        public Trip trip;
        public int TeacherId { get; set; }
        public Teacher teacher;
        public List<ToddlerScan> ToddlerScans { get; set; }
    }
}
