using Newtonsoft.Json; 
namespace PointsBet.Test{ 

    public class Winner
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

}