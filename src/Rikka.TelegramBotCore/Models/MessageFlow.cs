using System.Collections.Generic;

namespace TelegramBotCore.Models
{
    public class Messaging
    {
        public Messaging()
        {
            MessageFlow = new MessageFlow();
        }

        public Messaging(ISendItem sendItem) : this()
        {
            SendItem = sendItem;
        }

        public Messaging(int chatId, string message, object replyMarkup = null) : this()
        {
            SendItem = new SendMessageModel(chatId, message, replyMarkup);
        }

        public ISendItem SendItem { get; set; }
        public MessageFlow MessageFlow { get; set; }
    }

    public class MessageFlow:List<MessageFlowItem>
    {
        public MessageFlow()
        {

        }

        public MessageFlow(IEnumerable<MessageFlowItem> items):base(items)
        {

        }
    }
}