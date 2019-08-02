﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToddlerScanV2.Models
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }

        public DateTime expire_date { get; set; }
        public double expire_in { get; internal set; }

        public Token() { }

    }
}
