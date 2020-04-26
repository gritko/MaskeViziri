﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Models
{
    public class Contact
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public int AlternativePhoneNumber { get; set; }
    }
}
