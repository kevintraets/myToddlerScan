using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ToddlerScanV2.View;
using Xamarin.Forms;

namespace ToddlerScanV2.Models
{

    public class User 
    { 
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Username} and {Password}";
        }

    }
}
