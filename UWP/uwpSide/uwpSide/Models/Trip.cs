using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }
        public List<Toddler> Toddlers { get; set; }
    }
}
