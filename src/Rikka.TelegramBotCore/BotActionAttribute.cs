using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBotCore
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BotActionAttribute : Attribute
    {
    }
}
