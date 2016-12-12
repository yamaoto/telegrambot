using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ForceReplyModel
    {
        [JsonProperty(PropertyName="force_reply")]
        public bool ForceReply { get; set; }
        [JsonProperty(PropertyName = "selective")]
        public bool Selective { get; set; }
    }
}