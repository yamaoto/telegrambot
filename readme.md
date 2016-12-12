# TelegramBot

## Rikka.TelegamClasses

Проект содержит классы сообщений Telegram

## Rikka.TelegramBotCore

Проект содержит интерфейсы для построения бота

```
public class StartAction:IBotAction
{
	public bool Private => true;
    public bool Chat => true;
    public string[] States => new[] {"NoState"};
    public string CommandName => "/start";
    public string Description => null;

    public async Task<Messaging> Command(string command, MessageModel message)
    {
        return await Task.Run(() => _command(command, message));
    }

    private Messaging _command(string command, MessageModel message)
    {
        return new Messaging();
    }

    public async Task<Messaging> Message(string text, string state, MessageModel message)
    {
        return await Task.Run(() => _message(text, state, message));
    }

    private Messaging _message(string text, string state, MessageModel message)
    {
        var isPrivate = message.Chat.Id == message.From.Id;
            
        return isPrivate? new Messaging(message.Chat.Id, "Hello world!"): new Messaging();
    }
}
```