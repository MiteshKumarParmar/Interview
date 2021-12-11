using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Root
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("payload")]
        public Payload Payload { get; set; }
    }

}