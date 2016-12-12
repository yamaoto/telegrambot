using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class MessageModel
    {
        [JsonProperty(PropertyName="message_id")]
        public int MessageId { get; set; }
        [JsonProperty(PropertyName = "from")]
        public UserModel From { get; set; }
        [JsonProperty(PropertyName = "date")]
        public int Date { get; set; }
        [JsonProperty(PropertyName = "chat")]
        public ChatModel Chat { get; set; }
        [JsonProperty(PropertyName="forward_from")]
        public UserModel ForwardFrom { get; set; }
        [JsonProperty(PropertyName="forward_from_chat")]
        public ChatModel ForwardFromChat { get; set; }
        [JsonProperty(PropertyName="forward_date")]
        public int ForwardDate { get; set; }
        [JsonProperty(PropertyName="reply_to_message")]
        public MessageModel ReplyToMessage { get; set; }
        [JsonProperty(PropertyName="edit_date")]
        public int EditDate { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "entities")]
        public MessageEntryModel[] Entities { get; set; }
        [JsonProperty(PropertyName = "audio")]
        public AudioModel Audio { get; set; }
        [JsonProperty(PropertyName = "document")]
        public DocumentModel Document { get; set; }
        [JsonProperty(PropertyName = "photo")]
        public PhotoSizeModel[] Photo { get; set; }
        [JsonProperty(PropertyName = "sticker")]
        public StickerModel Sticker { get; set; }
        [JsonProperty(PropertyName = "video")]
        public VideoModel Video { get; set; }
        [JsonProperty(PropertyName = "voice")]
        public VoiceModel Voice { get; set; }
        [JsonProperty(PropertyName = "caption")]
        public string Caption { get; set; }
        [JsonProperty(PropertyName = "contact")]
        public ContactModel Contact { get; set; }
        [JsonProperty(PropertyName = "location")]
        public LocationModel Location { get; set; }
        [JsonProperty(PropertyName = "venue")]
        public VenueModel Venue { get; set; }
        [JsonProperty(PropertyName="new_chat_user")]
        public UserModel NewChatUser { get; set; }
        [JsonProperty(PropertyName="left_chat_user")]
        public UserModel LeftChatUser { get; set; }
        [JsonProperty(PropertyName="new_chat_title")]
        public string NewChatTitle { get; set; }
        [JsonProperty(PropertyName="new_chat_photo")]
        public PhotoSizeModel[] NewChatPhoto { get; set; }
        [JsonProperty(PropertyName="delete_chat_photo")]
        public bool DeleteChatPhoto { get; set; }
        [JsonProperty(PropertyName="group_chat_created")]
        public bool GroupChatCreated { get; set; }
        [JsonProperty(PropertyName="supergroup_chat_created")]
        public bool SupergroupChatCreated { get; set; }
        [JsonProperty(PropertyName="channel_chat_created")]
        public bool ChannelChatCreated { get; set; }
        [JsonProperty(PropertyName="migrate_to_chat_id")]
        public int MigrateToChatId { get; set; }
        [JsonProperty(PropertyName="migrate_from_chat_id")]
        public int MigrateFromChatId { get; set; }
        [JsonProperty(PropertyName="pinned_message")]
        public MessageModel PinnedMessage { get; set; }
    }
}