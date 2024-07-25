using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopy
{
    public class ShallowCopyUtil : IShallowCopyUtil
    {
        public AutoModel GetShallowClone(AutoModel autoModel)
        {
            return (AutoModel)this.MemberwiseClone();  //casting the return type 
        }
    }
}
