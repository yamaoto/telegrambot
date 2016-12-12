using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class UpdateModel
    {
        [JsonProperty(PropertyName="update_id")]
        public int UpdateId { get; set; }
        [JsonProperty(PropertyName = "message")]
        public MessageModel Message { get; set; }
        [JsonProperty(PropertyName="edited_message")]
        public MessageModel EditedMessage { get; set; }
        [JsonProperty(PropertyName="inline_query")]
        public InlineQueryModel InlineQuery { get; set; }
        [JsonProperty(PropertyName="chosen_inline_result")]
        public ChosenInlineResultModel ChosenInlineResult { get; set; }
        [JsonProperty(PropertyName="callback_query")]
        public CallbackQueryModel CallbackQuery { get; set; }
    }
}