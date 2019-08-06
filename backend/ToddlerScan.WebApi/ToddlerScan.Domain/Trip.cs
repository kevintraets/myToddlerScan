using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToddlerScan.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
        public List<Toddler> Toddlers { get; set; }

    }
}
