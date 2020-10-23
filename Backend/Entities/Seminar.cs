using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Seminar
    {   
        
        public int id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string Date { get; set; }

        public int NumberOfAvailableSeats { get; set; }

        public int Duration { get; set; }

        public IList<UserSeminar> userseminar { get; set; }
        

    }
}
