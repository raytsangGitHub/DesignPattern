using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public class CompressionContext
    {
        private ICompression _compression;  //use aggregration for reference the strategy

        public CompressionContext(ICompression Compression)  //Constructor Dependency Injection
        {
            this._compression = Compression;
        }
        //Using Method DI to SET to new a solution instance.
        //Acting as a switch for new instance. Instead of using the ctor instant.
        public void SetStrategy(ICompression Compression)  
        {
            this._compression = Compression; //set to the new instance from client
        }

        public void CreateArchive(string compressedArchiveFileName) //Method Dependency Injection
        {
            _compression.CompressFolder(compressedArchiveFileName);  //Call the solution
        }
    }
}
