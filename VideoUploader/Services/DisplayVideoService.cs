using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VideoUploader.Models;
using System.Text.Json;

namespace VideoUploader.Services
{
    public class DisplayVideoService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public readonly string VideoDataFileName;

        public DisplayVideoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
            VideoDataFileName = Path.Combine(WebHostEnvironment.WebRootPath, "data", "videoData.json");
        }

        public VideoData[] GetVideoData()
        {
            using StreamReader JsonFileReader = File.OpenText(VideoDataFileName);
            return JsonSerializer.Deserialize<VideoData[]>(JsonFileReader.ReadToEnd(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
