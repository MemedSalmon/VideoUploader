using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace VideoUploader.Models
{
    public class VideoData
    {

        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("VideoPath")]
        public string VideoPath { get; set; }

        [JsonPropertyName("Extension")]
        public string Extension { get; set; }

        [JsonPropertyName("ImagePath")]
        public string ImagePath { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}
