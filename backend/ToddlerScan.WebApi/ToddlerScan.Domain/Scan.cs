using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToddlerScan.Domain
{
    public class Scan
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int TripId { get; set; }
        [ForeignKey("TripId")]
        public Trip trip;
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher teacher;
        public List<ToddlerScan> ToddlerScans { get; set; }
    }
}
