﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phoneword.ViewModel
{
    public abstract class Person
    {
        public int ID { get; set; }

        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}
