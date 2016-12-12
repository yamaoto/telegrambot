using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ReplyKeyboardHideModel
    {
        [JsonProperty(PropertyName="hide_keyboard")]
        public bool HideKeyboard { get; set; }
        [JsonProperty(PropertyName = "selective")]
        public bool Selective { get; set; }
    }
}