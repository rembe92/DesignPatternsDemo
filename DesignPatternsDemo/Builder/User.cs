﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Builder
{
    class User
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public Address? Address { get; set; }

        public User(string? name)
        {
            Name = name;
        }
    }
}
