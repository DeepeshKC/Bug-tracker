﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Model
{
    public class Project
    {
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? AdminId { get; set; }
    }
}
