using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ChosenInlineResultModel
    {
        [JsonProperty(PropertyName="result_id")]
        public string ResultId { get; set; }
        [JsonProperty(PropertyName = "from")]
        public UserModel From { get; set; }
        [JsonProperty(PropertyName = "location")]
        public LocationModel Location { get; set; }
        [JsonProperty(PropertyName="inline_message_id")]
        public string InlineMessageId { get; set; }
        [JsonProperty(PropertyName="query")]
        public string Query { get; set; }
    }
}