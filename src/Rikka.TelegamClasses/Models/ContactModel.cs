using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ContactModel
    {
        [JsonProperty(PropertyName="user_id")]
        public int UserId { get; set; }
        [JsonProperty(PropertyName="first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName="last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName="phone_number")]
        public string PhoneNumber { get; set; }
    }
}