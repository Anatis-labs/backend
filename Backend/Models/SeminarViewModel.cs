using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class SeminarViewModel
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string Date { get; set; }

        public int NumberOfAvailableSeats { get; set; }

        public int Duration { get; set; }

    }
}
