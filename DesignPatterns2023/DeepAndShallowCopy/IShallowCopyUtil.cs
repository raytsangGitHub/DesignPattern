using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopy
{
    public interface IShallowCopyUtil
    {
        AutoModel GetShallowClone(AutoModel autoModel);
    }
}
