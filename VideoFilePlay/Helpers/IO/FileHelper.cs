using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VideoFilePlay.Helpers.IO
{
    public static class FileHelper
    {
        /// <summary>
        /// 检查删除存在的文件
        /// </summary>
        /// <param name="filePath">文件的路径</param>
        public static void DeleteIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="bytes">文件源</param>
        /// <param name="fileName">文件名</param>
        public static void SaveFile(byte[] bytes, string fileName)
        {
            try
            {
                DirectoryHelper.CreateIfNotExists(Path.GetDirectoryName(fileName));//创建不存在的文件夹
                using (FileStream fs = new FileStream(fileName.Trim(), FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ex:{ex.Message}|{fileName}");
            }
        }
        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static FileInfo[] GetFiles(string directory, string[] patternArray = null)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);
            if (patternArray == null || patternArray.Length == 0)
            {
                return dir.GetFiles();
            }
            else
            {
                return patternArray.SelectMany(p => dir.GetFiles(p)).ToArray();
            }
        }
    }
}
