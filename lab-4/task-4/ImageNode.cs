using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class ImageNode : LightElementNode
    {
        private IImageLoader _imageLoader;
        public string Src { get; private set; }
        public byte[] ImageData { get; private set; }

        public ImageNode(string src, IImageLoader imageLoader)
            : base("img", false, true)
        {
            _imageLoader = imageLoader;
            Src = src;
            LoadImage();
        }

        private void LoadImage()
        {
            ImageData = _imageLoader.LoadImage(Src);
        }

        public override string OuterHTML
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append($"<img src=\"{Src}\" alt=\"Image\" />");
                return sb.ToString();
            }
        }

        public override string InnerHTML => string.Empty;
    }

}
