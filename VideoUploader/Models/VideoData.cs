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
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Path")]
        public string Path { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
