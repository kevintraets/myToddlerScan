using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToddlerScan.Domain
{
    public class ToddlerScan
    {
        public int Id { get; set; }
        public int ToddlerId { get; set; }
        [ForeignKey("ToddlerId")]
        public Toddler Toddler { get; set; }
    }
}
