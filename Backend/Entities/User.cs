﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Entities
{
    public class User
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }
    }
}