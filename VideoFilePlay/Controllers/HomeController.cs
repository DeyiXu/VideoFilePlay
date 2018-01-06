using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoFilePlay.Helpers.IO;
using VideoFilePlay.Models;

namespace VideoFilePlay.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //视频文件列表
            string dirPath = Path.Combine(Environment.CurrentDirectory, @"wwwroot/videos");
            FileItemModel model = GetFileIteration(new DirectoryInfo(dirPath));
            return View(model);
        }
        public FileItemModel GetFileIteration(DirectoryInfo directory)
        {
            FileItemModel model = new FileItemModel
            {
                Directory = directory,
                Files = FileHelper.GetFiles(directory.FullName, new string[] { "*.mp4", "*.flv", "*.m3u8", "*.rtmp", "*.mp3" }),
                ChildFileItemList = new List<FileItemModel>()
            };
            foreach (var dir in DirectoryHelper.GetDirectories(directory.FullName))
            {
                model.ChildFileItemList.Add(GetFileIteration(dir));
            }
            return model;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
