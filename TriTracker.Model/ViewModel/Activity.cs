using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TriTracker.Model.ViewModel
{
    public class ActivityViewModel
    {

        public int Id { get; set; }

        [Required]
        public string AspNetUserId { get; set; }

        public Athlete Athlete { get; set; }

        public Race Race { get; set; }

        [Required]
        public ActivityType ActivityType { get; set; }

        [Required]
        [Display(Name="Distance (m)")]
        public decimal Distance { get; set; }

        [Required]
        [Display(Name = "Time Taken (seconds)")]
        public decimal TimeTaken { get; set; }

        public string StartLocation { get; set; }

        public string EndLocation { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public List<ActivitySegment> ActivitySegments { get; set; }

    }

    public enum ActivityType
    {
        Unnassigned = 0,
        Swim = 1,
        Cycle = 2,
        Run = 3
    }
}