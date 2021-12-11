using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Child
    {
        [JsonProperty("competitor_id")]
        public int CompetitorId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}