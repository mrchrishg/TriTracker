using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriTracker.Model.ViewModel
{
    public class AthleteViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PreferredEmail { get; set; }

        public string AspNetUserId { get; set; }

        public List<Activity> Activities { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
