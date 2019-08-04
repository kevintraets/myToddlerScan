using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScan.Domain
{
    public class ToddlerScan
    {
        public int Id { get; set; }
        public int ToddlerId { get; set; }
        public Toddler Toddler { get; set; }
    }
}
