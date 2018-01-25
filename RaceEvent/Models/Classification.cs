using System.Collections.Generic;

namespace RaceEvent.Models
{
    public class Classification
    {
        public string ID { get; set; }
        public int RaceId { get; set; }
        public int Bib { get; set; }
        public int Rank { get; set; }

        public virtual ICollection<Split> Splits { get; set; }
    }
}