using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Sport
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}