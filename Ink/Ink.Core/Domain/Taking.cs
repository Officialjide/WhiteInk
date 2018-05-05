using System;
using System.Collections.Generic;

namespace Ink.Core.Domain
{
    public class Taking
    {
        public Taking()
        {
            TakeDetails = new List<TakeDetail>();
        }
        public int Id { get; set; }
        public DateTime TakeDate { get; set; }
        public string TakeType { get; set; } //- Opening , - PointInTime, - Closing
        public int CenterId { get; set; }
        public virtual Center Center { get; set; }
        public string TakeAsAt { get; set; } //Taking for what date(day)
        public string UserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; } //not sure yet

        public virtual ICollection<TakeDetail> TakeDetails { get; set; }
    }
}
