using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy.VirtualProxy
{
    internal class RealImage : IImage
    {
        private string Filename { get; set; }

        public RealImage(string filename)
        {
            Filename = filename;
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {Filename}");
        }
        public void DisplayImage()
        {
            Console.WriteLine($"Displaying Image: {Filename}");
        }
    }
}
