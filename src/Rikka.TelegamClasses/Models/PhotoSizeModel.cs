using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class PhotoSizeModel
    {
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Weight { get; set; }
        [JsonProperty(PropertyName="file_size")]
        public int FileSize { get; set; }
    }
}