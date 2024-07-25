using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepAndShallowCopyDemo2
{
    public class CompanyDescription
    {
        public string CompanyName;
        public string Owner;
        public CompanyDescription(string c, string o)
        {
            this.CompanyName = c;
            this.Owner = o;
        }
    }
}
