using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VideoFilePlay.Helpers.IO
{
    /// <summary>
    /// 目录操作
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// 重建不存在的文件夹
        /// </summary>
        /// <param name="directory">目录创建</param>
        public static void CreateIfNotExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
        public static DirectoryInfo[] GetDirectories(string directory)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            return dir.GetDirectories();
        }
    }
}
