﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopy
{
    public class Address
    {
        public string address { get; set; } 

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
