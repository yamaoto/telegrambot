using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class ReplyKeyboardMarkupModel
    {
        public ReplyKeyboardMarkupModel()
        {

        }

        public ReplyKeyboardMarkupModel(KeyboardButtonModel[][] keyboard)
        {
            Keyboard = keyboard;
        }
        public ReplyKeyboardMarkupModel(IEnumerable<KeyboardButtonModel[]> keyboard)
        {
            Keyboard = keyboard.ToArray();
        }
        public ReplyKeyboardMarkupModel(IEnumerable<KeyboardButtonModel> keyboard)
        {
            Keyboard = keyboard.Select(s => new[] {s}).ToArray();
        }
        [JsonProperty(PropertyName = "keyboard")]
        public KeyboardButtonModel[][] Keyboard { get; set; }
        [JsonProperty(PropertyName="resize_keyboard")]
        public bool ResizeKeyboard { get; set; }

        [JsonProperty(PropertyName = "one_time_keyboard")]
        public bool OneTimeKeyboard { get; set; } = true;
        [JsonProperty(PropertyName = "selective")]
        public bool Selective { get; set; }
    }
}