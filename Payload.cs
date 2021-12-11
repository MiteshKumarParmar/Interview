using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace PointsBet.Test{ 

    public class Payload
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("markets")]
        public List<Market> Markets { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("winners")]
        public List<Winner> Winners { get; set; }
    }

}