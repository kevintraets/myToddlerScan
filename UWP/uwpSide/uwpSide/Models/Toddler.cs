using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Models
{
    public class Toddler
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}, in grade {Grade}";
        }
    }
}
