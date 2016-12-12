using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ResponseSendStickerModel
    {
        [JsonProperty(PropertyName = "chat_id")]
        public int ChatId { get; set; }
        [JsonProperty(PropertyName = "sticker")]
        public string Sticker { get; set; }
        [JsonProperty(PropertyName = "reply_to_message_id")]
        public int? ReplyToMessageId { get; set; }
        [JsonProperty(PropertyName = "reply_markup")]
        public object ReplyMarkup { get; set; }
        [JsonProperty(PropertyName = "disable_notification")]
        public bool DisableNotification { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; } = "sendSticker";
    }
}