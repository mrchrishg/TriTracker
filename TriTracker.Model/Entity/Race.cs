﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTracker.Model
{
    public class Race
    {
        public int Id { get; set; }

        public string RaceName { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
