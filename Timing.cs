using Newtonsoft.Json; 
using System; 
namespace PointsBet.Test{ 

    public class Timing
    {
        [JsonProperty("scheduled_begin")]
        public DateTime ScheduledBegin { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }
    }

}