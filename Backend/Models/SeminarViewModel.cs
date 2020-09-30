﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class SeminarViewModel
    {
        public string Name { get; set; }

        public string description { get; set; }

        public int numberOfAvailableSeats { get; set; }

        public DateTime Duration { get; set; }
    }
}
