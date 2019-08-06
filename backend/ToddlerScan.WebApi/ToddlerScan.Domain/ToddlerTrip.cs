using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToddlerScan.Domain
{
    public class ToddlerTrip
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        [ForeignKey("TripId")]
        public Trip Trip { get; set; }
        public int ToddlerId { get; set; }
        [ForeignKey("ToddlerId")]
        public Toddler Toddler { get; set; }
    }
}
