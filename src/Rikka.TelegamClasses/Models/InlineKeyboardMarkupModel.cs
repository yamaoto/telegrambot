using Newtonsoft.Json;

namespace TelegamClasses.Models
{

    
    public class InlineKeyboardMarkupModel
    {
        [JsonProperty(PropertyName="inline_keyboard")]
        public InlineKeyboardButtonModel[] InlineKeyboard { get; set; }
    }
}