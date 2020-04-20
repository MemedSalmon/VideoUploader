using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using VideoUploader.Models;
using VideoUploader.Services;

namespace VideoUploader.Pages
{
    public class VideosModel : PageModel
    {
        private readonly ILogger<VideosModel> Logger;

        public DisplayVideoService VideoService;

        public VideoData[] Videos;
        public VideosModel(ILogger<VideosModel> logger, DisplayVideoService videoService)
        {
            Logger = logger;
            VideoService = videoService;
        }
        public void OnGet()
        {
            Videos = VideoService.GetVideoData();
        }

        


    }
}
