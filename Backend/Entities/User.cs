using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public Seminar[] listOfBookedSeminars { get; set; }
    }
}
