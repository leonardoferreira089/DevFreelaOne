﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreelaOne.Models
{
    public class CreateUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }        
    }
}
