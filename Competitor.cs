using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PointsBet.Test{ 

    public class Competitor
    {
        [JsonProperty("competitor_id")]
        public int CompetitorId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("children")]
        public List<Child> Children { get; set; }
    }

}