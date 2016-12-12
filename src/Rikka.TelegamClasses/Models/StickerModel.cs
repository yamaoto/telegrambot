using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class StickerModel
    {
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }
        [JsonProperty(PropertyName = "thumb")]
        public PhotoSizeModel Thumb { get; set; }
        [JsonProperty(PropertyName = "emoji")]
        public string Emoji { get; set; }
        [JsonProperty(PropertyName="file_size")]
        public int FileSize { get; set; }
    }
}