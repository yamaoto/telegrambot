using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class CallbackQueryModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "from")]
        public UserModel From { get; set; }
        [JsonProperty(PropertyName = "message")]
        public MessageModel Message { get; set; }
        [JsonProperty(PropertyName="inline_message_id")]
        public string InlineMessageId { get; set; }
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
    }
}