﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    abstract class Employee {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string ShowFullName () {
            return FirstName + " " + LastName;
        }
    }
}
