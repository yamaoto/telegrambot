using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class UserModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName="first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName="last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
    }
}