using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpSide.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
