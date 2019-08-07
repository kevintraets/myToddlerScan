using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Models
{
    public class ToddlerScan
    {
        public int Id { get; set; }
        public int ToddlerId { get; set; }
        public Toddler Toddler { get; set; }
    }
}
