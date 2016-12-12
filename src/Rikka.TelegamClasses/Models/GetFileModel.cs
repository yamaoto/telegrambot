using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class GetFileModel
    {
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }

    }
}