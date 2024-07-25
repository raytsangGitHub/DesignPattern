using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy.VirtualProxy
{
    internal class ProxyImage : IImage
    {
        private RealImage realImage = null!;  // violated the OCP. Its coupled to RealImage. 
        private string? Filename { get; set; }

        public ProxyImage(string filename)
        {
            this.Filename = filename;
        }

        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(Filename);  //create new RealImage instance if no image available in the proxy
                realImage.LoadImageFromDisk();
            }
            realImage.DisplayImage();
        }
    }
}
