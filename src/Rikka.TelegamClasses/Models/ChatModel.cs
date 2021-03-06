using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ChatModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName="first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName="last_name")]
        public string LastName { get; set; }
    }
}