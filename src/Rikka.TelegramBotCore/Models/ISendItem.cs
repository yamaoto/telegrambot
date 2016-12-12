namespace TelegramBotCore.Models
{
    public interface ISendItem
    {
        int ChatId { get; set; }
        bool DisableNotification { get; set; }
    }
}