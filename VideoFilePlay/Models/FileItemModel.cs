using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VideoFilePlay.Models
{
    public class FileItemModel
    {
        public DirectoryInfo Directory { get; set; }
        public FileInfo[] Files { get; set; }
        public List<FileItemModel> ChildFileItemList { get; set; }
    }
}
