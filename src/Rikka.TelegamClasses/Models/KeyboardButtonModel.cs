using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class KeyboardButtonModel
    {
        public KeyboardButtonModel()
        {

        }
        public KeyboardButtonModel(string text)
        {
            Text = text;
        }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName="request_contact")]
        public bool RequestContact { get; set; }
        [JsonProperty(PropertyName="request_location")]
        public bool RequestLocation { get; set; }
    }
}