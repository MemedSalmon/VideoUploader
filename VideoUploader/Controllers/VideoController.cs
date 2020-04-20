using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoUploader.Models;
using VideoUploader.Services;

namespace VideoUploader.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        public UploadVideoService VideoService { get; }
        public DisplayVideoService DisplayService { get; }

        public VideoController(UploadVideoService videoService, DisplayVideoService displayService)
        {
            VideoService = videoService;
            DisplayService = displayService;
        }

        [HttpPost]
        public IActionResult Upload([FromForm] IFormFile videoFile, [FromForm] IFormFile thumbnailFile, [FromForm] string title, [FromForm] string description)
        {
            VideoService.Upload(VideoService.GenerateVideo(videoFile, thumbnailFile, title, description, VideoService.GenerateId()));
            return RedirectToPage("/Videos");
        }

        [Route("Watch")]
        [HttpPost]
        public IActionResult Watch([FromForm] string videoId)
        {
            return Redirect("/Watch?v=" + videoId);
        }

        [Route("Delete")]
        [HttpPost]
        public IActionResult Delete([FromForm] string videoId)
        {
            VideoData[] videoArray = DisplayService.GetVideoData();
            List<VideoData> videoList = videoArray.ToList();
            VideoService.DeleteFile(videoList.First(x => x.Id == videoId));
            videoList.Remove(videoList.First(x => x.Id == videoId));
            VideoService.Upload(videoList.ToArray());
            return Redirect("/Videos");
        }

        
    }
}