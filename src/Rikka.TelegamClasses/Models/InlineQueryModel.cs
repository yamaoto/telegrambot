using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class InlineQueryModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "from")]
        public UserModel From { get; set; }
        [JsonProperty(PropertyName = "location")]
        public LocationModel Location { get; set; }
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
    }
}