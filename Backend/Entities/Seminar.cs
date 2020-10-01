using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Seminar
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfAvailableSeats { get; set; }

        public int Duration { get; set; }

        public List<User> users { get; set; }
    }
}
