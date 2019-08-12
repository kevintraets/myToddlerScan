using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScanV2.Models
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
