﻿using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UserViewModel
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
        public IList<UserSeminar> userseminars { get; set; }


    }
}
