using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScanV2.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }
        public List<Toddler> Toddlers { get; set; }
    }
}
