using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Market
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

}