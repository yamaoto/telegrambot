using Newtonsoft.Json;
using TelegamClasses.Models;

namespace TelegramBotCore.Models
{
    
    public class SendMessageModel : ISendItem
    {
        public SendMessageModel(int chatId,string text, object replyMarkup=null)
        {
            ChatId = chatId;
            Text = text;
            ReplyMarkup = replyMarkup;
        }
        [JsonProperty(PropertyName="chat_id")]
        public int ChatId { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName="parse_mode")]
        public string ParseMode { get; set; }
        [JsonProperty(PropertyName="disable_web_page_preview")]
        public bool DisableWebPagePreview { get; set; }
        [JsonProperty(PropertyName="disable_notification")]
        public bool DisableNotification { get; set; }
        [JsonProperty(PropertyName="reply_to_message_id")]
        public int? ReplyToMessageId { get; set; }
        /// <summary>
        /// <see cref="InlineKeyboardButtonModel"/>, <see cref="ReplyKeyboardMarkupModel"/>, <see cref="ReplyKeyboardHideModel"/>, <see cref="ForceReplyModel"/>
        /// </summary>
        [JsonProperty(PropertyName="reply_markup")]
        public object ReplyMarkup { get; set; }
    }

    
    public class SendPhotoModel : ISendItem
    {
        public SendPhotoModel(int chatId, byte[] bytes)
        {
            ChatId = chatId;
            Photo = bytes;
        }
        [JsonProperty(PropertyName = "chat_id")]
        public int ChatId { get; set; }
        [JsonProperty(PropertyName = "photo")]
        public byte[] Photo { get; set; }
        [JsonProperty(PropertyName = "caption")]
        public string Caption { get; set; }
        [JsonProperty(PropertyName = "disable_notification")]
        public bool DisableNotification { get; set; }
        [JsonProperty(PropertyName = "reply_to_message_id")]
        public int? ReplyToMessageId { get; set; }
        /// <summary>
        /// <see cref="InlineKeyboardButtonModel"/>, <see cref="ReplyKeyboardMarkupModel"/>, <see cref="ReplyKeyboardHideModel"/>, <see cref="ForceReplyModel"/>
        /// </summary>
        [JsonProperty(PropertyName = "reply_markup")]
        public object ReplyMarkup { get; set; }
    }
}