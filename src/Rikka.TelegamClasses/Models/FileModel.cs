using Newtonsoft.Json;

namespace TelegamClasses.Models
{
    
    public class FileModel
    {
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }

        [JsonProperty(PropertyName = "file_size")]
        public int FileSize { get; set; }

        [JsonProperty(PropertyName = "file_path")]
        public string FilePath { get; set; }

    }
}