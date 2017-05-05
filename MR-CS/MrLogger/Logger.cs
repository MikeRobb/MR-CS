using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrLogger
{
    public class Logger
    {
        private string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="rootPath"></param>
        /// <param name="extension"></param>
        public Logger(string fileName, string rootPath, string extension = "log")
        {
            rootPath = rootPath.Trim();
            fileName = fileName.Trim();
            extension = extension.Trim();

            if (rootPath.EndsWith("/"))
                rootPath = rootPath.Substring(0, rootPath.Length - 1);

            if (fileName.StartsWith("/"))
                fileName = fileName.Substring(1);

            if (fileName.EndsWith("."))
                fileName = fileName.Substring(0, fileName.Length - 1);

            if (extension.StartsWith("."))
                extension = extension.Substring(1);

            Path = $"{rootPath}/{fileName}.{extension}";
        }

        public void Log(string msg, bool addDateTime = true)
        {
            var prefix = addDateTime ? DateTime.Now.ToString("hh:mm:ss tt : ") : string.Empty;
            File.AppendAllText(Path, $"{prefix}{msg}\r\n");
        }
    }
}
