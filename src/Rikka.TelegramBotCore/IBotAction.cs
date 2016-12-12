using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegamClasses.Models;
using TelegramBotCore.Models;

namespace TelegramBotCore
{
    public interface IBotAction
    {
        bool Private { get; }
        bool Chat { get; }
        string[] States { get; }
        string CommandName { get; }
        string Description { get; }
        Task<Messaging> Command(string command, MessageModel message);
        Task<Messaging> Message(string text, string state, MessageModel message);
    }
}
