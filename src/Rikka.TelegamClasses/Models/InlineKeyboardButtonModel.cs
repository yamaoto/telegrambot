using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class InlineKeyboardButtonModel
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName="callback_data")]
        public string CallbackData { get; set; }
        [JsonProperty(PropertyName="switch_inline_query")]
        public string SwitchInlineQuery { get; set; }
    }
}