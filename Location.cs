using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Location
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}