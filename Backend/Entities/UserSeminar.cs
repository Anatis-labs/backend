using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class UserSeminar
    {
        public int seminarid { get; set; }
        public IList<Seminar> seminars { get; set; }

        public int userid { get; set; }
        public IList<User> users { get; set; }



    }
}
