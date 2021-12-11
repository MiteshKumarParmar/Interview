using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PointsBet.Test{ 

    public class Metadata
    {
        [JsonProperty("sport")]
        public Sport Sport { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("timing")]
        public Timing Timing { get; set; }

        [JsonProperty("competitors")]
        public List<Competitor> Competitors { get; set; }
    }

}