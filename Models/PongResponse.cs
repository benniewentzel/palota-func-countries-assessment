using System;
using Newtonsoft.Json;
    
namespace Palota.Assessment.Countries.Models {
    public class PongResponse {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }
    }
}