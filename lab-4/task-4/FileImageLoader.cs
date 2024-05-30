using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class FileImageLoader : IImageLoader
    {
        public byte[] LoadImage(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            throw new FileNotFoundException("Image not found in the file system.", path);
        }
    }
}
