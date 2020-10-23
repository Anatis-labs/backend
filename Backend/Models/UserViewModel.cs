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

        public string description { get; set; }

        public List<Seminar> seminars { get; set; }


    }
}
