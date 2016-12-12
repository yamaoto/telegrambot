using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class TelegramResult<T>
    {
        [JsonProperty(PropertyName="ok")]
        public bool Ok { get; set; }

        [JsonProperty(PropertyName = "result")]
        public T Result { get; set; }
    }
}