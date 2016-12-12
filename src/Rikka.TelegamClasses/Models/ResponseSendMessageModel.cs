using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ResponseSendMessageModel
    {
        [JsonProperty(PropertyName = "chat_id")]
        public int ChatId { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "parse_mode")]
        public string ParseMode { get; set; }
        [JsonProperty(PropertyName = "disable_web_page_preview")]
        public bool DisableWebPagePreview { get; set; }
        [JsonProperty(PropertyName = "disable_notification")]
        public bool DisableNotification { get; set; }
        [JsonProperty(PropertyName = "reply_to_message_id")]
        public int? ReplyToMessageId { get; set; }
        /// <summary>
        /// <see cref="InlineKeyboardButtonModel"/>, <see cref="ReplyKeyboardMarkupModel"/>, <see cref="ReplyKeyboardHideModel"/>, <see cref="ForceReplyModel"/>
        /// </summary>
        [JsonProperty(PropertyName = "reply_markup")]
        public object ReplyMarkup { get; set; }
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; } = "sendSticker";
    }
}