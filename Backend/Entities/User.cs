using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Entities
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public IList<Seminar> seminars { get; set; }

    }
}
