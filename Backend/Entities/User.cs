using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Entities
{
    public class User
    {
        [ForeignKey("Seminar")]
        public int id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<UserSeminar> userseminars { get; set; }
    }
}
