using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UserSeminarViewModel
    {
        public int seminarId { get; set; }
        public Seminar seminar { get; set; }

        public int userId { get; set; }
        public User user { get; set; }

    }
}
