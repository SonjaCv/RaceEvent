using System.Collections.Generic;

namespace RaceEvent.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float DistanceInMeter { get; set; }

        public virtual IEnumerable<Classification> Classifications { get; set; }
    }
}