﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string? Title { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
