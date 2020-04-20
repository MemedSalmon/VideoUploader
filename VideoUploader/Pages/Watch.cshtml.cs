using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VideoUploader.Models;
using VideoUploader.Services;

namespace VideoUploader.Pages
{
    public class WatchModel : PageModel
    {
        public DisplayVideoService VideoService;

        public VideoData Video;

        public WatchModel(DisplayVideoService videoService)
        {
            VideoService = videoService;
        }

        public void OnGet([FromQuery] string v)
        {
            Video = VideoService.GetVideoData().First(x => x.Id == v);
        }
    }
}
