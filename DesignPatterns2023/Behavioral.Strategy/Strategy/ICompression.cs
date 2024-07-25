using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public interface ICompression
    {
        //Algorithm that compress the file
        void CompressFolder(string compressedArchiveFileName);
    }
}
