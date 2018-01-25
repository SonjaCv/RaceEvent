using System.Collections.Generic;

namespace RaceEvent.Models
{
    public class EventRace
    {
        public Event Event { get; set; }
        public virtual ICollection<Race> Races { get; set; }
    }
}