using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoUploader.Models;
using System.IO;
using System.Text.Json;

namespace VideoUploader.Services
{
    public class UploadVideoService
    {        
        public IWebHostEnvironment WebHostEnvironment { get; }

        public DisplayVideoService VideoService { get; }

        public UploadVideoService(IWebHostEnvironment webHostEnvironment, DisplayVideoService videoService)
        {
            WebHostEnvironment = webHostEnvironment;
            VideoService = videoService;
        }

        public string GenerateId()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] tempStr = new char[20];
            bool match = false;
            Random rand = new Random();
            IEnumerable<VideoData> videos = VideoService.GetVideoData();

            while (true) 
            { 
                for (int i = 0; i < tempStr.Length; i++)
                {
                    tempStr[i] = chars[rand.Next(chars.Length)];

                }          

                foreach (VideoData video in videos)
                {
                    if (video.Id == new string(tempStr))
                    {
                        match = true;
                        break;
                    }
                }

                if (!match)
                    break;
            }

            return new string(tempStr);
        }

        private string GenerateFile(IFormFile file, string folder, string id)
        {
            string extension = Path.GetExtension(file.FileName);
            string localFilePath = string.Format("{0}/{1}{2}", folder, id, extension);
            using FileStream fileStream = new FileStream(Path.Combine(WebHostEnvironment.WebRootPath, folder, string.Format("{0}{1}", id, extension)), FileMode.CreateNew, FileAccess.Write);
            file.CopyTo(fileStream);
            return localFilePath;
        }

        public void DeleteFile(VideoData video)
        {
            File.Delete(string.Format("{0}/{1}", WebHostEnvironment.WebRootPath, video.VideoPath));
            File.Delete(string.Format("{0}/{1}", WebHostEnvironment.WebRootPath, video.ImagePath));
        }

        public VideoData GenerateVideo(IFormFile videoFile, IFormFile thumbnailFile, string title, string description, string id)
        {
            VideoData video = new VideoData
            {
                VideoPath = GenerateFile(videoFile, "videos", id),
                Extension = videoFile.ContentType,
                ImagePath = GenerateFile(thumbnailFile, "thumbnails", id),
                Title = title,
                Description = description,
                Id = id
            };
            return video;
        }    

        public void Upload(VideoData video)
        {
            VideoData[] videoArray = VideoService.GetVideoData();
            List<VideoData> videoList = videoArray.ToList();
            videoList.Add(video);

            using StreamWriter sw = File.CreateText(VideoService.VideoDataFileName);
            sw.WriteLine("[");
            for (int i = 0; i < videoList.ToArray().Length; i++)
            {
                sw.Write(videoList.ToArray()[i].ToString());
                if(i != videoList.ToArray().Length - 1)
                {
                    sw.WriteLine(",");
                } else
                {
                    sw.WriteLine();
                }
            }
            sw.WriteLine("]");
        }

        public void Upload(VideoData[] videos)
        {
            using StreamWriter sw = File.CreateText(VideoService.VideoDataFileName);
            sw.WriteLine("[");
            for (int i = 0; i < videos.Length; i++)
            {
                sw.Write(videos.ToArray()[i].ToString());
                if (i != videos.ToArray().Length - 1)
                {
                    sw.WriteLine(",");
                }
                else
                {
                    sw.WriteLine();
                }
            }
            sw.WriteLine("]");
        }
    }
}
