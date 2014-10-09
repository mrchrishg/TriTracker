using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTracker.Model
{
    public class ActivitySegment
    {
        public int Id { get; set; }

        public Activity Activity {get;set;}

        public decimal Distance { get; set; }

        public decimal TimeTaken { get; set; }


        public string StartCoordinates { get; set; }

        public string EndCoordinates { get; set; }

    }
}
